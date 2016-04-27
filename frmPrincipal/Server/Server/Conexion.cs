using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using Serial;

namespace Server
{
    class Conexion
    {
        #region VARIABLES
        public OleDbConnection DBconexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Dropbox\frmPrincipal\MultiRubro\BDDMultiRubro.accdb");

        #endregion
        private static Conexion instance = null;
        private Conexion() 
        {
            DBconexion.Open();
        }
        public static Conexion getintance()
        {
            if (instance == null)
            {
                instance = new Conexion();
            }
            return instance;
        }
        public OleDbDataReader ConsultaDatos(string Consulta)
        {
            
            OleDbCommand DBcomnado = new OleDbCommand(Consulta+";", DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            return DBdatareader;
        }
        public bool InsertarDatos(string Consulta)
        {
            
            OleDbCommand DBcomnado = new OleDbCommand(Consulta, DBconexion);
            OleDbDataReader DBdatareader;
            
            try
            {
                DBdatareader = DBcomnado.ExecuteReader();                
                return true;
            }
            catch
            {
                
                return false;
            }
        }
        public int AutentificarDatos(string User, string Pass)
        {
            int Prioridad;
            string consulta = "SELECT * FROM Usuarios where User='" + User + "' and Password='" + Pass + "';";
            
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                Prioridad = Convert.ToInt32(DBdatareader[3]);
                
                return Prioridad;
            }
            
            return -1;
        }
        public string FirmaEmpleado(string User, string Pass)
        {
            string Firma = "";
            int id_Cajero = 0;
            string consulta = "SELECT * FROM Usuarios where User='" + User + "' and Password='" + Pass + "';";
            
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                id_Cajero = Convert.ToInt32(DBdatareader[4].ToString());
            }
            string consulta2 = "SELECT * FROM Usuarios, Cajeros where Usuarios.IdCajero=" + id_Cajero + " and Cajeros.IdCajero=" + id_Cajero + ";";
            DBcomnado = new OleDbCommand(consulta2, DBconexion);
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                Firma = DBdatareader[6].ToString() + " " + DBdatareader[6].ToString();
            }
            
            return Firma;
        }
        public DataTable CargarProductos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio Venta");
            OleDbDataReader DBdatareader = ConsultaDatos("Select *From Productos");
            while (DBdatareader.Read())
            {
                DataRow row = dt.NewRow();
                dt.Rows.Add(new Object[] { DBdatareader["Cod_Producto"].ToString(), DBdatareader[2].ToString(), DBdatareader[6].ToString() });
            }
            
            return dt;
        }
        public DataTable CargarCliente()
        {
            DataTable dt = new DataTable();
            
            OleDbCommand DBcomnado = new OleDbCommand("SELECT * FROM Cliente;", DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("3");
            dt.Columns.Add("4");
            dt.Columns.Add("5");
            dt.Columns.Add("6");
            dt.Columns.Add("7");
            dt.Columns.Add("8");
            dt.Columns.Add("9");
            dt.Columns.Add("10");
            while (DBdatareader.Read())
            {
                DataRow row = dt.NewRow();
                row[0] = DBdatareader[0].ToString();
                row[1] = DBdatareader[1].ToString();
                row[2] = DBdatareader[2].ToString();
                row[3] = DBdatareader[3].ToString();
                row[4] = DBdatareader[4].ToString();
                row[5] = DBdatareader[5].ToString();
                row[6] = DBdatareader[6].ToString();
                row[7] = DBdatareader[7].ToString();
                row[8] = DBdatareader[8].ToString();
                row[9] = DBdatareader[9].ToString();
                dt.Rows.Add(row);
            }
            
            return dt;
        }
        internal int GenerarTicket()
        {
            int Ticket = 0;
            string consulta = "Select * FROM Ticket";
            
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                Ticket = Convert.ToInt32(DBdatareader[0].ToString());
            }
            Ticket ++;
            
            return Ticket;
        }
        internal int ObtenerID(string p1, string p2)
        {
            string consulta = "SELECT * FROM Usuarios where User='" + p1 + "' and Password='" + p2 + "';";
            
            int r;
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                r = Convert.ToInt32(DBdatareader[0].ToString());
                
                return r;
            }
            
            return -1;
        }
        internal double CajaInicial(int id)
        {
            string consulta = "SELECT * FROM Terminales where IdTerminal=" + id +";";
            
            double r ;
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                if (DBdatareader[1].ToString() == "0")
                {
                    r = 0;
                }
                else
                {
                    r = Convert.ToDouble(DBdatareader[1].ToString());
                }
                
                return r;
            }
            
            return -1;
        }
        public void CargarTicket(int IDTerminal,int Ticket)
        {
            InsertarDatos("insert into Ticket (Cod_Ticket,Cod_Detalle,Total,IDTerminal) values ("+Ticket+","+Ticket+",0,"+IDTerminal+")");
            
        }
        internal int GenerarRetiroN()
        {
            int Retiro = 0;
            string consulta = "Select * FROM Retiro";
            
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                Retiro = Convert.ToInt32(DBdatareader[5].ToString());
            }
            Retiro++;
            
            return Retiro;
        }
        internal void CargarRetiro(int IDTerminal, int Retiro)
        {
            InsertarDatos("insert into Retiro (IDTerminal,IdRetiro) values (" + IDTerminal + ","+Retiro+")");
        }
        public void ObtenerRetiro(Mensaje msj,int idRetiro)
        {
            string consulta = "Select * FROM Retiro where IdRetiro = "+idRetiro+"";
            
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                msj.Monto = Convert.ToDouble(DBdatareader[1].ToString());
                msj._Mensaje = DBdatareader[2].ToString();
                msj.Empleado = DBdatareader[3].ToString();
                msj.Hora = DBdatareader[4].ToString();
            }
            
        }
        internal void ObtenerVenta(Mensaje msj, int p)
        {
            bool Factura = false;
            msj.dt_Venta = new DataTable();
            msj.dt_Venta.Columns.Add("Cantidad");
            msj.dt_Venta.Columns.Add("Precio Unitario");
            msj.dt_Venta.Columns.Add("Precio Total");
            msj.dt_Venta.Columns.Add("Descripcion");
            msj.dt_Venta.Columns.Add("Codigo");
            string consulta = "Select * FROM Ticket,Factura where Ticket.Cod_Ticket = " + p + " and Factura.Cod_Ticket = "+p+"";
            
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                Factura = true;
            }
            if (Factura == true)
            {
                msj.Correcto = true;
                msj.Correcto = false;
                DBcomnado = new OleDbCommand("Select * FROM Detalle where Cod_Detalle = " + p + "", DBconexion);
                DBdatareader = DBcomnado.ExecuteReader();
                while (DBdatareader.Read())
                {
                    DataRow dr = msj.dt_Venta.NewRow();
                    dr[0] = DBdatareader[1].ToString();
                    dr[1] = DBdatareader[2].ToString();
                    dr[2] = DBdatareader[3].ToString();
                    dr[3] = DBdatareader[4].ToString();
                    dr[4] = DBdatareader[5].ToString();
                    msj.dt_Venta.Rows.Add(dr);
                }
                DBcomnado = new OleDbCommand("Select * FROM Ticket where Cod_Ticket = " + p + "", DBconexion);
                DBdatareader = DBcomnado.ExecuteReader();
                while (DBdatareader.Read())
                {
                    msj.Porcentaje = Convert.ToInt32(DBdatareader[5].ToString());
                }
            }else
            {
                msj.Correcto = false;
                DBcomnado = new OleDbCommand("Select * FROM Detalle where Cod_Detalle = "+p+"",DBconexion);
                DBdatareader = DBcomnado.ExecuteReader();
                while (DBdatareader.Read())
                {
                    DataRow dr = msj.dt_Venta.NewRow();
                    dr[0] = DBdatareader[1].ToString();
                    dr[1] = DBdatareader[2].ToString();
                    dr[2] = DBdatareader[3].ToString();
                    dr[3] = DBdatareader[4].ToString();
                    dr[4] = DBdatareader[5].ToString();
                    msj.dt_Venta.Rows.Add(dr);
                }
                DBcomnado = new OleDbCommand("Select * FROM Ticket where Cod_Ticket = " + p + "", DBconexion);
                DBdatareader = DBcomnado.ExecuteReader();
                while (DBdatareader.Read())
                {
                    msj.Porcentaje = Convert.ToInt32(DBdatareader[5].ToString());
                }
            }
            
        }
        internal void EliminarTicket(int p)
        {
            string consulta = "DELETE FROM Logs WHERE Cod_Ticket = " + p + "";
            
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            consulta = "delete from Ticket where Cod_Ticket = " + p + "";
            DBcomnado = new OleDbCommand(consulta, DBconexion);
            DBdatareader = DBcomnado.ExecuteReader();
            consulta = "delete from Factura where Factura.Cod_Ticket = " + p + "";
            DBcomnado = new OleDbCommand(consulta, DBconexion);
            DBdatareader = DBcomnado.ExecuteReader();
            consulta = "delete * from Detalle where Cod_Detalle = " + p + "";
            DBcomnado = new OleDbCommand(consulta, DBconexion);
            DBdatareader = DBcomnado.ExecuteReader();
            
        }
        public void CargarStock(int Codigo,int Cantidad)
        {
            int Cant = 0;
            int Cant_P = 0;
            string consulta = "Select * FROM Productos where Cod_Producto = " + Codigo + "";
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                Cant = Convert.ToInt32(DBdatareader["Cantidad"].ToString());
                Cant_P = Convert.ToInt32(DBdatareader["Cantida_Particionable"].ToString());
            }
            int total = (Cant * Cant_P) + Cantidad;
            Cant = total / Cant_P;
            consulta = "Update Productos set Cantidad = " + Cant + ", Cantidad_Total = " + total + " where Cod_Producto = " + Codigo + "";
            DBcomnado = new OleDbCommand(consulta, DBconexion);
            DBdatareader = DBcomnado.ExecuteReader();
        }
        internal void DescontarStock(Int64 Codigo, int Cantidad)
        {
            int Cant = 0;
            int Cant_P = 0;
            string consulta = "Select * FROM Productos where Cod_Producto = " + Codigo + "";
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                Cant = Convert.ToInt32(DBdatareader["Cantidad"].ToString());
                Cant_P = Convert.ToInt32(DBdatareader["Cantida_Particionable"].ToString()); 
            }
            int total = (Cant*Cant_P)-Cantidad;
            Cant = total / Cant_P;
            consulta = "Update Productos set Cantidad = "+Cant+", Cantidad_Total = "+total+" where Cod_Producto = "+Codigo+"";
            DBcomnado = new OleDbCommand(consulta, DBconexion);
            DBdatareader = DBcomnado.ExecuteReader();
        }
        internal void ActualizarEstadoCuenta(Mensaje msg)
        {
            double EstadoCuenta = 0;
            string consulta = "Select * FROM Cliente where Cod_Cliente = " + msg.IdCliente + "";
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                EstadoCuenta = Convert.ToDouble(DBdatareader["Estado_Cuenta"].ToString());
            }
            EstadoCuenta = EstadoCuenta - msg.Monto;
            InsertarDatos("update Cliente set Estado_Cuenta = '"+EstadoCuenta+"' where Cod_Cliente = "+msg.IdCliente+"");
        }
        internal void ObetenerCuenta(Mensaje msj, int p)
        {
            msj.dt_Aux = new DataTable();
            msj.dt_Aux.Columns.Add("Fecha");
            msj.dt_Aux.Columns.Add("Nº Ticket");
            msj.dt_Aux.Columns.Add("Descripcion");
            msj.dt_Aux.Columns.Add("Total");
            string consulta = "Select * FROM Factura where Factura.Cod_Cliente = " + p + "";
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                DataRow dr = msj.dt_Aux.NewRow();
                dr[0] = DBdatareader["Fecha"].ToString();
                dr[1] = DBdatareader["Cod_Ticket"].ToString();
                dr[2] = "Venta Factura";
                dr[3] = DBdatareader["Total"].ToString();
                msj.dt_Aux.Rows.Add(dr);
            }
            consulta = "Select * FROM Pagos where Pagos.Cod_Cliente = " + p + "";
            DBcomnado = new OleDbCommand(consulta, DBconexion);
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                DataRow dr = msj.dt_Aux.NewRow();
                dr[0] = DBdatareader["Fecha"].ToString();
                dr[1] = DBdatareader["IdPagos"].ToString();
                dr[2] = "ENTREGA";
                dr[3] = DBdatareader["Monto"].ToString();
                msj.dt_Aux.Rows.Add(dr);
            }
        }
        internal double ObetenerCosto(long p)
        {
            double aux=0;
            string consulta = "Select * FROM Productos where Cod_Producto = " + p + "";
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                aux = Convert.ToDouble(DBdatareader["Precio_Costo"].ToString());
            }
            return aux;
        }

        internal void ResetearTablas()
        {
            if (DBconexion.State == ConnectionState.Open)
            {
                DBconexion.Close();
                DBconexion.Open();
            }
        }
    }
}
