using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Xml;
using System.Collections;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Serial;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Server
{
    class Terminales
    {
        private Conexion conexion = Conexion.getintance();
        private NetworkStream Stream;
        private TcpClient Client;
        private Thread Hilo;
        private Class1 serial;
        private bool Estado;
        public int IDTerminal;
        public int IDUsuario;
        public double CajaInicial;
        private Datos datos = Datos.getDatos();
        public Terminales(TcpClient _Client)
        {
            serial = new Class1();
            Estado = true;
            this.Client = _Client;
            Hilo = new Thread(SubProceso);
            Hilo.Start();
        }
        private void SubProceso()
        {
            int intentos = 0;
            while (Estado)
            {
                Byte[] msj = new Byte[40000];
                try
                {
                    Stream = Client.GetStream();
                    //conexion.ResetearTablas();
                }
                catch
                {
                    Estado = false;
                    if (intentos == 5)
                    {
                        break;
                    }
                    intentos++;
                    continue;
                }
                try
                {
                    Stream.Read(msj, 0, msj.Length);
                    _Datos(serial.LoadMensaje(msj));
                }
                catch
                {
                    Console.WriteLine("Perdio un paquete de datos");
                    continue;
                }
            }
        }
        private void _Datos(Mensaje msg)
        {
            switch (msg.op)
            {
                case 0:
                    int prioridad = conexion.AutentificarDatos(msg.User, msg.Password);
                    if (prioridad != -1)
                    {
                        Mensaje msn = new Mensaje();
                        msn.op = 0;
                        msn.Prioridad = prioridad;
                        msn.Correcto = true;
                        msn._Mensaje = conexion.FirmaEmpleado(msg.User, msg.Password);
                        EnviarMensaje(serial.SerializarObj(msn));
                        IDUsuario = conexion.ObtenerID(msg.User, msg.Password);
                        conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('Inicio Sesion'," + IDUsuario + "," +msg.CajaActual+ "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
                    }
                    break;
                case 1:
                    conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('Cerrar Sesion'," + IDUsuario + "," +msg.CajaActual+ "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
                    break;
                case 2: 
                    CargarTicket(msg);
                    DescontarStock(msg);
                    ActualizarCaja(msg);
                    break;
                case 3:
                    CargarNuevoCliente(msg);
                    break;
                case 4:
                    CargarFactura(msg);
                    DescontarStock(msg);
                    ActualizarCaja(msg);
                    break;
                case 5:
                    conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('Retiro'," + IDUsuario + "," +msg.CajaActual+ "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
                    conexion.InsertarDatos("update Retiro set RetiroMonto = '"+msg.Monto+"', Nota = '"+msg._Mensaje+"' , Empleado = '"+msg.Empleado+"', Hora = '"+msg.Hora+"' where IdRetiro = "+msg.IdRetiro+"");
                    ActualizarCaja(msg);
                    Mensaje msj = new Mensaje();
                    msj.IdRetiro = datos.getRetiro(IDTerminal);
                    msj.op = 7;
                    EnviarMensaje(serial.SerializarObj(msj));
                    break;
                case 6:
                    EnviarRetiro(msg);
                    break;
                case 7:
                    EnviarVenta(msg);
                    break;
                case 8:
                    conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('Modificar Venta Guardado'," + IDUsuario + "," + msg.CajaActual + "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
                    GuardarVenta(msg);
                    SumarStock(msg);
                    break;
                case 9:
                    CargarFactura(msg);
                    DescontarStock(msg);
                    break;
                case 10 :// Elimina Ticket
                    conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('Eliminar Ticket '," + IDUsuario + "," + msg.CajaActual + "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
                    EliminarTicket(msg);
                    SumarStock(msg);
                    break;
                case 11://Cierra terminal
                    CerrarTerminal(msg);
                    break;
                case 12://Abre venta de cliente
                    EnviarVenta_(msg);
                    break;
                case 13://Abona Deuda
                    conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('Pago Deuda '," + IDUsuario + "," + msg.CajaActual + "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
                    conexion.InsertarDatos("Insert into Pagos (Cod_Cliente,Fecha,Monto,Nota) values (" + msg.IdCliente + ",'" + DateTime.Now.ToLocalTime() + "','"+msg.Monto+"','"+msg._Mensaje+"')");
                    conexion.ActualizarEstadoCuenta(msg);
                    break;
                case 14:
                    EnviarCuenta(msg);
                    break;
                case 15:
                    conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('Venta a Credito '," + IDUsuario + "," + msg.CajaActual + "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
                    CargarFactura(msg);
                    DescontarStock(msg);
                    conexion.ActualizarEstadoCuenta(msg);
                    break;
                case 16:
                    EnviarDatosDeposito(1);
                    break;
                case 17:
                    if (conexion.AutentificarDatos(msg.User, msg.Password) == 2)
                    {
                        Mensaje ms = new Mensaje();
                        ms.Correcto = true;
                        ms.op = 2;
                        EnviarMensaje(serial.SerializarObj(ms));
                    }
                    else
                    {
                        Mensaje ms = new Mensaje();
                        ms.Correcto = false;
                        ms.op = 2;
                        EnviarMensaje(serial.SerializarObj(ms));
                    }
                    break;
                case 18:
                    SumarStock(msg);
                    break;
                case 19:
                    DatosProducto(msg);
                    break;
                case 20:
                    CargarProducto(msg);
                    EnviarDatosDeposito(5);
                    break;
                case 21:
                    DataRow dr = msg.dt_Aux.Rows[0];
                    conexion.InsertarDatos("Delete * from Productos where Cod_Producto = "+dr[0]+" and Cod_Proveedor = "+dr[1]+"");
                    EnviarDatosDeposito(5);
                    break;
                case 22:
                    conexion.InsertarDatos("INSERT into Proveedores (Nombre_RazonSocial, Cuit_Cuil, Direccion, Numero_Telefono, Correo, Ciudad, EstadoCuenta, Fecha_Ultima_Compra) Values('" + msg.proveedor.Nombre + "', '" + msg.proveedor.Cuit + "', '" + msg.proveedor.Direccion + "', '" + msg.proveedor.Telefono + "', '" + msg.proveedor.Email + "', '" + msg.proveedor.Ciudad + "'," + 0 + ",'" + DateTime.Now.ToLocalTime() + "')");
                    EnviarDatosDeposito(5);
                    break;
                case 23:
                    EnviarProductos();
                    break;
                case 24:
                    Estado = false;
                    break;
                case 25:
                    EnviarPreciosCosto();
                    break;
                case 26:
                    DescontarStock(msg);
                    conexion.InsertarDatos("insert into Devoluciones (Cod_Proveedor,Descripcion,Devolucion) values (" + msg.IdCliente + ",'" + msg._Mensaje + "','" + msg.Monto + "')");
                    break;
            }
        }

        private void EnviarPreciosCosto()
        {
            Mensaje msj = new Mensaje();
            msj.op = 6;
            msj.dt_Aux = new DataTable();
            msj.dt_Aux.Columns.Add("Cod");
            msj.dt_Aux.Columns.Add("Precio");
            OleDbDataReader dr = conexion.ConsultaDatos("Select * from Productos");
            while (dr.Read())
            {
                DataRow dtr = msj.dt_Aux.NewRow();
                dtr[0] = dr["Cod_Producto"].ToString();
                dtr[1] = dr["Precio_Costo"].ToString();
                msj.dt_Aux.Rows.Add(dtr);
            }
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void EnviarProductos()
        {
            Mensaje msj = new Mensaje();
            msj.op = 4;
            msj.dt_Productos = new DataTable();
            msj.dt_Productos.Columns.Add("cod");
            msj.dt_Productos.Columns.Add("des");
            msj.dt_Productos.Columns.Add("precio");
            msj.dt_Productos.Columns.Add("rubro");
            OleDbDataReader dr = conexion.ConsultaDatos("Select *from Productos");
            while (dr.Read())
            {
                DataRow dtr = msj.dt_Productos.NewRow();
                dtr[0] = dr["Cod_Producto"];
                dtr[1] = dr["Descripcion_Ticket"];
                dtr[2] = dr["Precio_Unitario"];
                dtr[3] = dr["Categoria"];
                msj.dt_Productos.Rows.Add(dtr);
            }
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void CargarProducto(Mensaje msg)
        {
            conexion.InsertarDatos("INSERT into Productos (Cod_Producto, Descripcion, Descripcion_Ticket, Cantidad, Cantida_Particionable, Cantidad_Total, Precio_Unitario, Precio_Costo, Porcentaje_Ganancia, Cod_Proveedor, Categoria, Stock_Critico) " +
                    "Values(" + msg.producto.Codigo + ", '" + msg.producto.Descripcion + "', '" + msg.producto.DescripcionTicket + "', " +msg.producto.Cantidad + ", " + msg.producto.Cantidad_Particionable + "," + msg.producto.Cantidad_Total + ", '" + msg.producto.PrecioVenta+ "', '" + msg.producto.PrecioCosto + "', '" + msg.producto.Ganancia + "', '" + msg.IdCliente+ "', '" + msg.producto.Rubro + "', " + msg.producto.StockCritico + ")");
        }
        private void DatosProducto(Mensaje msj)
        {
            OleDbDataReader dr = conexion.ConsultaDatos("Select * from Productos where Cod_Producto = "+Convert.ToInt64(msj._Mensaje)+"");
            Mensaje msg = new Mensaje();
            msg.op = 3;
            msg.producto = new Producto();
            while (dr.Read())
            {
                msg.producto.Descripcion = dr["Descripcion"].ToString();
                msg.producto.DescripcionTicket = dr["Descripcion_Ticket"].ToString();
                msg.producto.Cantidad = Convert.ToInt32(dr["Cantidad"].ToString());
                msg.producto.Cantidad_Particionable = Convert.ToInt32(dr["Cantida_Particionable"].ToString());
                msg.producto.Cantidad_Total = Convert.ToInt32(dr["Cantidad_Total"].ToString());
                msg.producto.PrecioCosto = Convert.ToDouble(dr["Precio_Costo"].ToString());
                msg.producto.PrecioVenta = Convert.ToDouble(dr["Precio_Unitario"].ToString());
                msg.producto.Ganancia = Convert.ToDouble(dr["Porcentaje_Ganancia"].ToString());
                msg.producto.StockCritico = Convert.ToInt32(dr["Stock_Critico"].ToString());
                msg.producto.Rubro = dr["Categoria"].ToString();
                break;
            }
            EnviarMensaje(serial.SerializarObj(msg));
        }
        public void EnviarDatosDeposito(int i)
        {
            Mensaje ms = new Mensaje();
            ms.op = i;
            ms.dt_Aux = new DataTable();
            ms.dt_Aux.Columns.Add("Cod");
            ms.dt_Aux.Columns.Add("Nombre");
            ms.dt_Productos = new DataTable();
            ms.dt_Productos.Columns.Add("Cod");
            ms.dt_Productos.Columns.Add("Des");
            ms.dt_Productos.Columns.Add("Cant");
            ms.dt_Productos.Columns.Add("Cod_Proveedor");
            OleDbDataReader dr = conexion.ConsultaDatos("Select *from Productos");
            while (dr.Read())
            {
                DataRow dtrow = ms.dt_Productos.NewRow();
                dtrow[0] = dr["Cod_Producto"].ToString();
                dtrow[1] = dr["Descripcion"].ToString();
                dtrow[2] = dr["Cantidad_Total"].ToString();
                dtrow[3] = dr["Cod_Proveedor"].ToString();
                ms.dt_Productos.Rows.Add(dtrow);
            }
            dr = conexion.ConsultaDatos("Select *from Proveedores");
            while (dr.Read())
            {
                DataRow dtrow = ms.dt_Aux.NewRow();
                dtrow[0] = dr["Cod_Proveedor"].ToString();
                dtrow[1] = dr["Nombre_RazonSocial"].ToString();
                ms.dt_Aux.Rows.Add(dtrow);
            }
            EnviarMensaje(serial.SerializarObj(ms));
        }
        public void EnviarDatosTerminal()
        {
            DataTable dt_p = conexion.CargarProductos();
            DataTable dt_c = conexion.CargarCliente();
            Mensaje msj = new Mensaje();
            msj.dt_Clientes = dt_c;
            msj.dt_Productos = dt_p;
            msj.op = 1;
            msj.N_Ticket = datos.getTicket(IDTerminal);
            msj.IdRetiro = datos.getRetiro(IDTerminal);
            msj.Monto = conexion.CajaInicial(IDTerminal);
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void EnviarCuenta(Mensaje msg)
        {
            Mensaje msj = new Mensaje();
            msj.op = 8;
            conexion.ObetenerCuenta(msj, msg.IdCliente);
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void CerrarTerminal(Mensaje msg)
        {
            string cerrar = "NºTicket Descartado : " + msg.N_Ticket;
            string cerra2 = "NºRetiro Descartado : " + msg.IdRetiro;
            conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('Cerrando Terminal '," + IDUsuario + "," + msg.CajaActual + "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
            conexion.InsertarDatos("UPDATE Terminales SET Caja_Actual = '" + msg.CajaActual + "', Caja_Inicial = '" + msg.CajaActual + "' where IdTerminal = " + IDTerminal + ";");
            conexion.InsertarDatos("Delete from Ticket where Cod_Ticket = " + msg.N_Ticket + "");
            conexion.InsertarDatos("Delete from Retiro where IdRetiro = " + msg.IdRetiro + "");
            conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('" + cerrar + "'," + IDUsuario + "," + msg.CajaActual + "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
            conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal) values ('" + cerra2 + "'," + IDUsuario + "," + msg.CajaActual + "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
            Estado = false;
            datos.getTerminales().Remove(Stream);
        }
        private void EliminarTicket(Mensaje msg)
        {
            conexion.EliminarTicket(msg.N_Ticket);
        }
        private void GuardarVenta(Mensaje msg)
        {
            conexion.InsertarDatos("UPDATE Ticket SET Total = '" + msg.Monto + "', Descuento = "+msg.Porcentaje+" where Cod_Ticket = " + msg.N_Ticket + ";");
            foreach (DataRow dr in msg.dt_Aux.Rows)
            {
                conexion.InsertarDatos("Delete Detalle where Cod_Detalle = "+msg.N_Ticket+" and Cod_Producto = "+Convert.ToInt64(dr[0].ToString())+"");
            }
            foreach (DataRow dr in msg.dt_Venta.Rows)
            {
                conexion.InsertarDatos("UPDATE Detalle SET Cantidad = " + Convert.ToInt32(dr[2].ToString()) + ", Precio_Total = '" + Convert.ToDouble(dr[4].ToString()) + "' where Cod_Detalle = " + msg.N_Ticket + ";");
            }
        }
        private void EnviarVenta(Mensaje msg)
        {
            Mensaje msj = new Mensaje();
            msj.op = 6;
            msj.N_Ticket = msg.N_Ticket;
            conexion.ObtenerVenta(msj, msg.N_Ticket);
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void EnviarVenta_(Mensaje msg)
        {
            Mensaje msj = new Mensaje();
            msj.op = 9;
            msj.Correcto = true;
            msj.N_Ticket = msg.N_Ticket;
            conexion.ObtenerVenta(msj, msg.N_Ticket);
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void EnviarRetiro(Mensaje msg)
        {
            Mensaje msj = new Mensaje();
            msj.op = 5;
            conexion.ObtenerRetiro(msj,msg.N_Ticket);
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void ActualizarCaja(Mensaje msg)
        {
            conexion.InsertarDatos("UPDATE Terminales SET Caja_Actual = '"+msg.CajaActual+"' where IdTerminal = " + IDTerminal + ";");
        }
        private void CargarFactura(Mensaje msg)
        {
            Int64 cod = 0;
            int cant = 0;
            double ganancia = 0;
            conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal,Cod_Ticket) values ('Venta Factura'," + IDUsuario + "," + msg.CajaActual + "," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + "," + msg.N_Ticket + ")");
            conexion.InsertarDatos("UPDATE Ticket SET Fecha = '" + DateTime.Now.ToLocalTime() + "', Total = '" + msg.Monto + "' , Descuento = " + msg.Porcentaje + ", Nota = '"+msg._Mensaje+"' where Cod_Ticket = " + msg.N_Ticket + ";");
            conexion.InsertarDatos("insert into Factura (Cod_Ticket,Cod_Cliente,Fecha,Total,Cod_Detalle,Iva,IDTerminal) values (" + msg.N_Ticket + "," + msg.cliente.Cod_Cliente + ",'" + DateTime.Now.ToLocalTime() + "','"+msg.Monto+"',"+msg.N_Ticket+",'"+msg.IVA+"',"+IDTerminal+")");
            DataTable dt_Venta = msg.dt_Venta;
            foreach (DataRow dr in dt_Venta.Rows)
            {
                conexion.InsertarDatos("insert into Detalle (Cod_Detalle,Cantidad,Precio_Unitario,Precio_Total,Descripcion_Ticket,Cod_Producto) values (" + msg.N_Ticket + "," + Convert.ToInt32(dr[2].ToString()) + ",'" + Convert.ToDouble(dr[3].ToString()) + "','" + Convert.ToDouble(dr[4].ToString()) + "','" + dr[1].ToString() + "'," + Convert.ToInt64(dr[0].ToString()) + ")");
                cod = Convert.ToInt64(dr[0].ToString());
                cant = Convert.ToInt32(dr[2].ToString());
                ganancia =  Convert.ToDouble(dr[4].ToString())-(Convert.ToInt32(dr[2].ToString()) * conexion.ObetenerCosto(Convert.ToInt64(dr[0].ToString()))) ;
                conexion.InsertarDatos("insert into Vendidos (Fecha,Descripcion,Cod_Producto,Cantidad,Ganancia)values('" + DateTime.Now.ToLocalTime() + "','" + dr[1].ToString() + "'," + cod + "," + cant + ",'" + ganancia + "')");
            }
            Mensaje msj = new Mensaje();
            msj.op = 4;
            msj.N_Ticket = datos.getTicket(IDTerminal);
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void CargarNuevoCliente(Mensaje msg)
        {
            conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Dia,Terminal) values ('Nuevo Cliente'," + IDUsuario + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + ")");
            conexion.InsertarDatos("insert into Cliente (Nombre_RazonSocial,Cuit_Cuil,Direccion,Numero_Telefono,Email,Ciudad,Nombre_Responsable,Telefono_Responsable,Estado_Cuenta) values ('" + msg.cliente.NombreRazonSocial + "','"+msg.cliente.Cuit_Cuil+"','"+msg.cliente.Direccion+"','"+msg.cliente.Telefono+"','"+msg.cliente.Email+"','"+msg.cliente.Ciudad+"','"+msg.cliente.Nombre_Responsable+"','"+msg.cliente.Telefono_Responsable+"',0)");
            Mensaje msj = new Mensaje();
            msj.op = 2;
            msj.dt_Clientes = conexion.CargarCliente();
            foreach (DictionaryEntry hs in datos.getTerminales())
            {
                EnviarMensaje((NetworkStream)hs.Key, serial.SerializarObj(msj));
            }
        }
        private void CargarTicket(Mensaje msg)
        {
            Int64 cod = 0;
            int cant = 0;
            double ganancia = 0;
            conexion.InsertarDatos("Insert into Logs (Descripcion,Usuario,Caja_Actual,Caja_Inicial,Dia,Terminal,Cod_Ticket) values ('Venta Ticket'," + IDUsuario + "," + msg.CajaActual +"," + CajaInicial + ",'" + DateTime.Now.ToLocalTime() + "'," + IDTerminal + "," + msg.N_Ticket + ")");
            conexion.InsertarDatos("UPDATE Ticket SET Fecha = '" + DateTime.Now.ToLocalTime() + "', Total = '" + msg.Monto + "' , Descuento = " + msg.Porcentaje + ", Nota = '" + msg._Mensaje + "' where Cod_Ticket = " + msg.N_Ticket + ";");
            DataTable dt_Venta = msg.dt_Venta;
            foreach (DataRow dr in dt_Venta.Rows)
            {
                conexion.InsertarDatos("insert into Detalle (Cod_Detalle,Cantidad,Precio_Unitario,Precio_Total,Descripcion_Ticket,Cod_Producto) values (" + msg.N_Ticket + "," + Convert.ToInt32(dr[2].ToString()) + ",'" + Convert.ToDouble(dr[3].ToString()) + "','" + Convert.ToDouble(dr[4].ToString()) + "','" + dr[1].ToString() + "'," + Convert.ToInt64(dr[0].ToString()) + ")");
                cod = Convert.ToInt64(dr[0].ToString());
                cant = Convert.ToInt32(dr[2].ToString());
                ganancia = Convert.ToDouble(dr[4].ToString()) - (Convert.ToInt32(dr[2].ToString()) * conexion.ObetenerCosto(Convert.ToInt64(dr[0].ToString())));
                conexion.InsertarDatos("insert into Vendidos (Fecha,Descripcion,Cod_Producto,Cantidad,Ganancia)values('" + DateTime.Now.ToLocalTime() + "','" + dr[1].ToString() + "'," + cod + "," + cant + ",'" + ganancia + "')");
            }
            Mensaje msj = new Mensaje();
            msj.op = 4;
            msj.N_Ticket = datos.getTicket(IDTerminal);
            EnviarMensaje(serial.SerializarObj(msj));
        }
        private void EnviarMensaje(byte[] bites)
        {
            try
            {
                Client.GetStream();
                Stream.Write(bites, 0, bites.Length);
                Stream.Flush();
            }
            catch
            {
                
            }
        }
        private void DescontarStock(Mensaje msg)
        {
            foreach (DataRow dr in msg.dt_Productos.Rows)
            {
                conexion.DescontarStock(Convert.ToInt64(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()));
            }
        }
        private void SumarStock(Mensaje msg)
        {
            foreach (DataRow dr in msg.dt_Productos.Rows)
            {
                conexion.CargarStock(Convert.ToInt32(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()));
            }
        }
        private void EnviarMensaje(NetworkStream Stream, byte[] bites)
        {
            try
            {
                Stream.Write(bites, 0, bites.Length);
                Stream.Flush();
            }
            catch
            {

            }
        }
        ~Terminales()
        {
            MessageBox.Show("Discconect Terminal");
        }
    }
}
