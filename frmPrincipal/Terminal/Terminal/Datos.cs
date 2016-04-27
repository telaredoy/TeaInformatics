using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Serial;
using System.Windows.Forms;

namespace Terminal
{
    public class Datos
    {
        public DataTable dt_Productos;
        public DataTable dt_Clientes;
        private ClienteDeuda cd;
        private Mensaje mensaje;
        public int IdRetiro;
        public double CajaActual;
        public double CajaInicial;
        public int Prioridad = -1;
        private Loguin loguin;
        private Cliente cliente;
        public string FirmaEmpleado;
        public int N_Ticket = 0;
        private Label ticket;
        private Label ClienteName;
        private frm_Terminal t;
        private frm_Ventas Ventas_F;
        public Datos(Loguin loguin,Label ticket, Label ClienteName, frm_Terminal t)
        {
            this.loguin = loguin;
            this.ticket = ticket;
            this.ClienteName = ClienteName;
            this.t = t;
        }
        public void setVentas(frm_Ventas Ventas_F)
        {
            this.Ventas_F = Ventas_F;
        }
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
            ClienteName.Text = cliente.NombreRazonSocial + "  CUIT-CUIL : " + cliente.Cuit_Cuil;
            t.MostrarBotones();
        }
        public Cliente getCliente()
        {
            return cliente;
        }
        public void SubMensaje(int op, Mensaje msj)
        {
            switch (op)
            {
                case 0:
                    if (msj.Correcto)
                    {
                        this.Prioridad = msj.Prioridad;
                        this.FirmaEmpleado = msj._Mensaje;
                    }
                    else
                    {
                        loguin.ErrorConectar();
                    }
                    break;
                case 1:
                    this.mensaje = msj;
                    dt_Clientes = msj.dt_Clientes;
                    dt_Productos = msj.dt_Productos;
                    this.IdRetiro = msj.IdRetiro;
                    this.N_Ticket = msj.N_Ticket;
                    this.CajaInicial = msj.Monto;
                    this.CajaActual = msj.Monto;
                    loguin.setCaja(msj.Monto.ToString());
                    break;
                case 2:
                    this.mensaje = msj;
                    this.dt_Clientes = msj.dt_Clientes;
                    break;
                case 4:
                    this.mensaje = msj;
                    this.N_Ticket = msj.N_Ticket;
                    this.ticket.Text = N_Ticket.ToString();
                    break;
                case 5:
                    this.mensaje = msj;
                    Retiro retiro = new Retiro(msj.Monto.ToString(), msj._Mensaje, msj.Empleado, msj.Hora);
                    retiro.ShowDialog();
                    break;
                case 6:
                    this.mensaje = msj;
                    Venta venta = new Venta(msj.N_Ticket, msj.dt_Venta, msj.Porcentaje,this,msj.Correcto,Ventas_F);
                    venta.ShowDialog();
                    break;
                case 7:
                    this.mensaje = msj;
                    this.IdRetiro = msj.IdRetiro;
                    break;
                case 8:
                    this.mensaje = msj;
                    cd.CargarTabla(msj.dt_Aux);
                    break;
                case 9:
                    this.mensaje = msj;
                    Venta venta_ = new Venta(msj.dt_Venta, msj.Porcentaje, msj.N_Ticket);
                    venta_.ShowDialog();
                    break;
            }
        }

        internal void setClienteDeuda(ClienteDeuda cd)
        {
            this.cd = cd;
        }
    }
}
