using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Serial;
using System.Threading;

namespace Terminal
{
    public partial class frm_Terminal : Form
    {
        public ConexionSocket CS;
        public string Cod,Desc,PrecioVenta;
        private Datos datos;
        private Loguin loguin;
        private double Total;
        private Send send;
        private Class1 cs;
        private Ventas ventas;
        private double Descuento;
        private bool Descuento_;
        private int TicketN;
        public frm_Terminal()
        {
            InitializeComponent();
            
        }
        private void EventClick(object sender, EventArgs e)
        {
            if (btn_PagarDeuda == sender)
            {
                if (datos.getCliente().Cod_Cliente != 0)
                {
                    ClienteDeuda cd = new ClienteDeuda(this, datos);
                    datos.setClienteDeuda(cd);
                    cd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El cliente no tiene deuda");
                }
            }
            if (btn_VentaACredito == sender)
            {
                if (lv_Detalle.Items.Count > 0)
                {
                    Sumar();
                    Mensaje msj = new Mensaje();
                    msj.op = 15;
                    CargarVenta(msj, true);
                    CargaProducto(msj);
                    ventas.CargarVenta(Convert.ToInt32(lb_Ticket.Text), Total, datos.FirmaEmpleado, DateTime.Now.ToString());
                    msj.cliente = datos.getCliente();
                    msj.IVA = Total * 21 / 100;
                    send.EnviarMensaje(cs.SerializarObj(msj));
                    CamposNormal();
                    //imprimirTicket();
                    //imprimirTicketAclaracion();
                }
                else
                {
                    MessageBox.Show("Alerta 0 items en ticket!!");
                }
            }
            if (btn_Limpiar == sender)
            {
                lv_Detalle.Items.Clear();
                label_Total.Text = "$ 0.00";
                Total = 0;
            }
            if (btn_Ventas == sender)
            {
                frm_Ventas frm = new frm_Ventas(this);
                frm.ShowDialog();
            }
            if (btn_Retiros == sender)
            {
                frm_Retiro frm = new frm_Retiro(datos,this);
                frm.ShowDialog();
            }
            if (btn_Cliente == sender)
            {
                frm_Cliente clinte = new frm_Cliente(datos,this);
                clinte.ShowDialog();
            }
            if (btn_Borrar == sender)
            {
                foreach (ListViewItem l in lv_Detalle.SelectedItems)
                {
                    l.Remove();
                    Sumar();
                    CentrarFoco();
                }
            }
            if (btn_CerrarSesion == sender)
            {
                Control control = new Control(datos,this);
                control.ShowDialog();
                CentrarFoco();
            }
            if (btn_Imprimir == sender)
            {
                if (lv_Detalle.Items.Count > 0)
                {

                    //imprimirTicket();
                    Sumar();
                    Mensaje msj = new Mensaje();
                    msj.op = 2;
                    CargarVenta(msj, false);
                    CargaProducto(msj);
                    ventas.CargarVenta(Convert.ToInt32(lb_Ticket.Text), Total, datos.FirmaEmpleado, DateTime.Now.ToString());
                    CamposNormal();
                    send.EnviarMensaje(cs.SerializarObj(msj));
                }
                else
                {
                    MessageBox.Show("Alerta 0 items en ticket!!");
                }
            }
            if (btn_Cancelar == sender)
            {
                string nTicket = lb_Ticket.Text;
                CamposNormal();
                lb_Ticket.Text = nTicket;
            }
            if (btn_ImprimirB == sender)
            {
                if (lv_Detalle.Items.Count > 0)
                {

                    Sumar();
                    Mensaje msj = new Mensaje();
                    msj.op = 4;
                    if (datos.getCliente().NombreRazonSocial == "Consumidor Final")
                    {
                        msj.cliente = new Cliente(1, "Consumidor Final", "", "", "", "", "", "","");
                    }
                    else
                    {
                        msj.cliente = datos.getCliente();
                    }
                    msj.IVA = Total * 21 / 100;
                    CargarVenta(msj, false);
                    CargaProducto(msj);
                    ventas.CargarVenta(Convert.ToInt32(lb_Ticket.Text), Total, datos.FirmaEmpleado, DateTime.Now.ToString());
                    CamposNormal();
                    send.EnviarMensaje(cs.SerializarObj(msj));
                    //imprimirTicket();
                }
                else
                {
                    MessageBox.Show("Alerta 0 items en ticket!!");
                }
            }
            if (btn_ImprimirC == sender)
            {
                if (lv_Detalle.Items.Count > 0)
                {

                    Sumar();
                    Mensaje msj = new Mensaje();
                    msj.op = 9;
                    if (datos.getCliente().NombreRazonSocial == "Consumidor Final")
                    {
                        msj.cliente = new Cliente(1, "Consumidor Final", "", "", "", "", "", "", "");
                    }
                    else
                    {
                        msj.cliente = datos.getCliente();
                    }
                    msj.IVA = Total * 21 / 100;
                    CargarVenta(msj, true);
                    CargaProducto(msj);
                    //imprimirTicket(); 
                    ventas.CargarVenta(Convert.ToInt32(lb_Ticket.Text), Total, datos.FirmaEmpleado, DateTime.Now.ToString());
                    CamposNormal();
                    send.EnviarMensaje(cs.SerializarObj(msj));
                }
                else
                {
                    MessageBox.Show("Alerta 0 items en ticket!!");
                }
            }
        }
        public void Carga() // Carga Producto Repitente lo suma y arregla la cantidad io Agrega nuevo
        {
            foreach (ListViewItem l in lv_Detalle.Items)
            {
                if (l.SubItems[0].Text == Cod)
                {
                    int aux = Convert.ToInt32(l.SubItems[2].Text);
                    aux += Convert.ToInt32(txt_Cantidad.Text);
                    l.SubItems[2].Text = aux.ToString();
                    l.SubItems[4].Text = (aux * Convert.ToDouble(l.SubItems[3].Text)).ToString();
                    txt_Codigo.Text = "";
                    txt_Cantidad.Text = "1";
                    Cod = "";
                    Desc = "";
                    PrecioVenta = "";
                    return;
                }
            }
            ListViewItem listitem = new ListViewItem(Cod);
            listitem.SubItems.Add(Desc);
            listitem.SubItems.Add(txt_Cantidad.Text);
            listitem.SubItems.Add(PrecioVenta);
            listitem.SubItems.Add((Convert.ToDouble(PrecioVenta) * Convert.ToInt32(txt_Cantidad.Text)).ToString());
            lv_Detalle.Items.Add(listitem);
            txt_Codigo.Text = "";
            txt_Cantidad.Text = "1";
            Cod = "";
            Desc = "";
            PrecioVenta = "";
        }
        public void Carga(int cantidad) // Carga Producto Repitente lo suma y arregla la cantidad io Agrega nuevo
        {
            foreach (ListViewItem l in lv_Detalle.Items)
            {
                if (l.SubItems[0].Text == Cod)
                {
                    int aux = Convert.ToInt32(l.SubItems[2].Text);
                    aux += Convert.ToInt32(cantidad);
                    l.SubItems[2].Text = aux.ToString();
                    l.SubItems[4].Text = (aux * Convert.ToDouble(l.SubItems[3].Text)).ToString();
                    txt_Codigo.Text = "";
                    txt_Cantidad.Text = "1";
                    Cod = "";
                    Desc = "";
                    PrecioVenta = "";
                    return;
                }
            }
            ListViewItem listitem = new ListViewItem(Cod);
            listitem.SubItems.Add(Desc);
            listitem.SubItems.Add(cantidad.ToString());
            listitem.SubItems.Add(PrecioVenta);
            listitem.SubItems.Add((Convert.ToDouble(PrecioVenta) * cantidad).ToString());
            lv_Detalle.Items.Add(listitem);
            txt_Codigo.Text = "";
            txt_Cantidad.Text = "1";
            Cod = "";
            Desc = "";
            PrecioVenta = "";
        }
        public void Sumar() // Sumador de total
        {
            double aux = 0;
            foreach (ListViewItem l in lv_Detalle.Items)
            {
                aux += Convert.ToDouble(Convert.ToDouble(l.SubItems[3].Text) * Convert.ToInt32(l.SubItems[2].Text));
            }
            if (txt_Descuento.Text != "")
            {
                Total = CalcularDescuento(aux, Convert.ToInt32(txt_Descuento.Text));
                label_Total.Text = "$ " + Total.ToString();
            }
            else
            {
                MessageBox.Show("Porcentaje no puede ser vacio");
            }
        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (txt_Descuento == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    Sumar();
                    e.Handled = true;
                    Descuento = Total-(Total+(Total * Convert.ToInt32(txt_Descuento.Text) / 100));
                    Descuento_ = true;
                }
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }

            }
            if (txt_Codigo == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    foreach (DataRow l in datos.dt_Productos.Rows)
                    {
                        if (txt_Codigo.Text == l[0].ToString())
                        {
                            Cod = l[0].ToString();
                            Desc = l[1].ToString();
                            PrecioVenta = l[2].ToString();
                            Carga();
                            txt_Codigo.Select();
                            Sumar();
                            return;
                        }

                    }
                    MessageBox.Show("No exite codigo o es incorrecto");
                }
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }

            }
            if (txt_Cantidad == sender)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    if (e.KeyChar == (Char)Keys.Enter)
                    {
                        if (txt_Cantidad.Text == "" || txt_Cantidad.Text == " " || txt_Cantidad.Text == "0")
                        {
                            txt_Cantidad.Text = "1";
                            txt_Codigo.Select();
                        }
                        else
                        {
                            txt_Codigo.Select();
                        }
                    }
                    return;
                }
            }
        }
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frm_Cliente clinte = new frm_Cliente(datos,this);
                clinte.ShowDialog();
            }
            if (e.KeyCode == Keys.F5)
            {
                frm_FiltroProductos frm = new frm_FiltroProductos(datos, lv_Detalle, label_Total,this);
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                txt_Cantidad.Select();
            }
        }
        private void imprimirTicket()
        {
            CrearTicket ticket = new CrearTicket();
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("TICKET");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("", "#"+lb_Ticket.Text);
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            foreach (ListViewItem i in lv_Detalle.Items)
            {
                ticket.AgregaArticulo(i.SubItems[1].Text, Convert.ToInt16(i.SubItems[2].Text), Convert.ToDecimal(i.SubItems[3].Text), Convert.ToDecimal(i.SubItems[4].Text));
            }
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            if (Descuento_ == false)
            {
                ticket.AgregarTotales("         TOTAL.........$", Convert.ToDecimal(Total));
            }
            else
            {
                ticket.AgregarTotales("         SUBTOTAL.........$", Convert.ToDecimal(Total));
                ticket.AgregarTotales("         DESCUENTO %" + txt_Descuento.Text + "   $", Convert.ToDecimal(Descuento));
                ticket.AgregarTotales("         TOTAL.........$", Convert.ToDecimal(Total - Descuento));
            }

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }
        private void imprimirTicketAclaracion()
        {
            CrearTicket ticket = new CrearTicket();
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("TICKET");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Cliente : "+datos.getCliente().NombreRazonSocial);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("", "#" + lb_Ticket.Text);
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            foreach (ListViewItem i in lv_Detalle.Items)
            {
                ticket.AgregaArticulo(i.SubItems[1].Text, Convert.ToInt16(i.SubItems[2].Text), Convert.ToDecimal(i.SubItems[3].Text), Convert.ToDecimal(i.SubItems[4].Text));
            }
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            if (Descuento_ == false)
            {
                ticket.AgregarTotales("         TOTAL.........$", Convert.ToDecimal(Total));
            }
            else
            {
                ticket.AgregarTotales("         SUBTOTAL.........$", Convert.ToDecimal(Total));
                ticket.AgregarTotales("         DESCUENTO %" + txt_Descuento.Text + "   $", Convert.ToDecimal(Descuento));
                ticket.AgregarTotales("         TOTAL.........$", Convert.ToDecimal(Total - Descuento));
            }

            //Texto final del Ticket.
            ticket.TextoIzquierda("FIRMA ..................");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Aclaracion .............");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        
        }
        private void CamposNormal()
        {
            Cliente cliente = new Cliente("Consumidor Final", "00-00000000-0", "", "", "", "", "", "");
            datos.setCliente(cliente);
            lv_Detalle.Items.Clear();
            lb_Ticket.Text = "";
            label_Total.Text = "$ 0.00";
            Total = 0;
            txt_Codigo.Select();
            txt_Cantidad.Text = "1";
            txt_Nota.Text = "";
            OcultarBotones();

        }
        private void CargarVenta(Mensaje msj,bool Tarjeta)
        {
            msj.dt_Venta = new DataTable();
            msj.N_Ticket = Convert.ToInt32(lb_Ticket.Text);
            msj.dt_Venta.Columns.Add("Codigo");
            msj.dt_Venta.Columns.Add("Descripcion");
            msj.dt_Venta.Columns.Add("Cantidad");
            msj.dt_Venta.Columns.Add("Precio Unitario");
            msj.dt_Venta.Columns.Add("Precio Total");
            msj.Porcentaje = Convert.ToInt32(txt_Descuento.Text);
            msj.Monto = Total;
            msj._Mensaje = txt_Nota.Text;
            if (Tarjeta == false)
            {
                msj.CajaActual = datos.CajaActual + Total;
                datos.CajaActual = datos.CajaActual + Total;
            }else
            {
                msj.CajaActual = datos.CajaActual;
            }
            foreach (ListViewItem l in lv_Detalle.Items)
            {
                DataRow dr = msj.dt_Venta.NewRow();
                dr[0] = l.SubItems[0].Text;
                dr[1] = l.SubItems[1].Text;
                dr[2] = l.SubItems[2].Text;
                dr[3] = l.SubItems[3].Text;
                dr[4] = l.SubItems[4].Text;
                msj.dt_Venta.Rows.Add(dr);
            }
        }
        private void frm_Terminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CS.Connected)
            {
                Mensaje msj = new Mensaje();
                msj.N_Ticket = datos.N_Ticket;
                msj.CajaActual = datos.CajaActual;
                msj.op = 11;
                msj.IdRetiro = datos.IdRetiro;
                send.EnviarMensaje(cs.SerializarObj(msj));
                CS.Connected = false;
                CS = null;
            }
        }
        public void CerrarSesion_()
        {
            lv_Detalle.Items.Clear();
            btn_Ventas.Enabled = false;
            label6.Visible = false;
            txt_Descuento.Visible = false;
            Descuento_ = false;
            TicketN = Convert.ToInt32(lb_Ticket.Text);
            CamposNormal();
            lb_Ticket.Text = TicketN.ToString();
            Mensaje msj = new Mensaje();
            msj.op = 1;
            datos.Prioridad = -1;
            send.EnviarMensaje(cs.SerializarObj(msj));
            loguin.Cargar(CS);
            while (datos.Prioridad == -1)
            {
                loguin.ShowDialog();
                Thread.Sleep(1000);
            }
            CamposNormal();
            lb_Ticket.Text = datos.N_Ticket.ToString();
            if (datos.Prioridad == 1)
            {
                btn_Ventas.Enabled = true;
                label6.Visible = true;
                txt_Descuento.Visible = true;
            }
        }
        internal void MostrarBotones()
        {
            btn_Cancelar.Visible = true;
            btn_PagarDeuda.Visible = true;
            btn_VentaACredito.Visible = true;
        }
        internal void OcultarBotones()
        {
            btn_Cancelar.Visible = false;
            btn_PagarDeuda.Visible = false;
            btn_VentaACredito.Visible = false;
        }
        public void CentrarFoco()
        {
            txt_Codigo.Select();
        }
        private double CalcularDescuento(double Precio, int Porcentaje)
        {
            return (Precio - (Precio * Porcentaje / 100));
        }
        private void LeaveEvent(object sender, EventArgs e)
        {
            if (txt_Cantidad == sender)
            {
                if (txt_Cantidad.Text == "" || txt_Cantidad.Text == " " || txt_Cantidad.Text == "0")
                {
                    txt_Cantidad.Text = "1";
                }
            }
        }
        private void frm_Terminal_Load(object sender, EventArgs e)
        {
            cs = new Class1();
            ventas = Ventas.getInstance();
            send = Send.GetSend();
            loguin = new Loguin();
            datos = new Datos(loguin, lb_Ticket, Label_Cliente, this);
            CheckForIllegalCrossThreadCalls = false;
            CS = new ConexionSocket(lv_Detalle, label_Total, datos);
            if (CS.Connected)
            {
                loguin.Cargar(CS);
                while (datos.Prioridad == -1)
                {
                    loguin.ShowDialog();
                    Thread.Sleep(1000);
                }
                CamposNormal();
                lb_Ticket.Text = datos.N_Ticket.ToString();
                if (datos.Prioridad == 1)
                {
                    btn_Ventas.Enabled = true;
                    label6.Visible = true;
                    txt_Descuento.Visible = true;
                }
            }
            else
            {
                this.Close();
            }
        }
        private void CargaProducto(Mensaje msj)
        {

            msj.dt_Productos = new DataTable();
            msj.dt_Productos.Columns.Add("Cod");
            msj.dt_Productos.Columns.Add("Cantidad");
            foreach (ListViewItem l in lv_Detalle.Items)
            {
                DataRow dr = msj.dt_Productos.NewRow();
                dr[0] = l.SubItems[0].Text;
                dr[1] = l.SubItems[2].Text;
                msj.dt_Productos.Rows.Add(dr);
            }
        }
        internal void CerrarTerminal()
        {
            this.Close();
        }
    }
}
