using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Serial;

namespace Terminal
{
    public partial class Venta : Form
    {
        private Class1 c = new Class1();
        private double total;
        private double totalinicial;
        private Send send = Send.GetSend();
        private DataTable dt_Productos;
        private DataTable dt_Aux;
        private Datos datos;
        private bool Factura;
        private frm_Ventas Ventas_F;
        public Venta(int NTicket,DataTable dt,int Descuento,Datos datos,bool Factura,frm_Ventas Ventas_F)
        {
            InitializeComponent();
            this.Ventas_F = Ventas_F;
            this.datos = datos;
            this.Factura = Factura;
            dt_Aux = new DataTable();
            dt_Productos = new DataTable();
            dt_Aux.Columns.Add("Codigo");
            dt_Productos.Columns.Add("Codigo");
            dt_Productos.Columns.Add("Cantidad");
            txt_Descuento.Text = Descuento.ToString();
            lb_Ticket.Text = NTicket.ToString();
            total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem l = new ListViewItem(dr[4].ToString());
                l.SubItems.Add(dr[3].ToString());
                l.SubItems.Add(dr[0].ToString());
                l.SubItems.Add(dr[1].ToString());
                l.SubItems.Add(dr[2].ToString());
                total += CalcularDescuento(Convert.ToDouble(dr[2].ToString()), Convert.ToInt32(txt_Descuento.Text));
                l.SubItems.Add(CalcularDescuento(Convert.ToDouble(dr[2].ToString()),Convert.ToInt32(txt_Descuento.Text)).ToString());
                lv_Detalle.Items.Add(l);
            }
            totalinicial = total;
        }
        public Venta(DataTable dt, int Descuento, int NTicket)
        {
            InitializeComponent();
            lb_Ticket.Text = NTicket.ToString();
            txt_Descuento.Text = Descuento.ToString();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem l = new ListViewItem(dr[4].ToString());
                l.SubItems.Add(dr[3].ToString());
                l.SubItems.Add(dr[0].ToString());
                l.SubItems.Add(dr[1].ToString());
                l.SubItems.Add(dr[2].ToString());
                total += CalcularDescuento(Convert.ToDouble(dr[2].ToString()), Convert.ToInt32(txt_Descuento.Text));
                l.SubItems.Add(CalcularDescuento(Convert.ToDouble(dr[2].ToString()), Convert.ToInt32(txt_Descuento.Text)).ToString());
                lv_Detalle.Items.Add(l);
            }
            lv_Detalle.Enabled = false;
            btn_Borrar.Visible = false;
            btn_Cancelar.Visible = false;
            btn_Cantidad.Visible = false;
            btn_EliminarTicket.Visible = false;
            btn_Guardar.Visible = false;
            label3.Visible = false;
            txt_Cantidad.Visible = false;
            txt_Descuento.Enabled = false;
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Borrar == sender)
            {
                foreach (ListViewItem l in lv_Detalle.SelectedItems)
                {
                    total = total - Convert.ToDouble(l.SubItems[4].Text);
                    DataRow dr = dt_Aux.NewRow();
                    dr[0] = l.SubItems[0].Text;
                    l.Remove();
                }
            }
            if (btn_Cancelar == sender)
            {
                this.Close();

            }
            if (btn_EliminarTicket == sender)
            {
                Mensaje msj = new Mensaje();
                msj.op = 10;
                msj.N_Ticket = Convert.ToInt32(lb_Ticket.Text);
                msj.CajaActual = datos.CajaActual - totalinicial;
                msj.dt_Productos = new DataTable();
                msj.dt_Productos.Columns.Add("Codigo");
                msj.dt_Productos.Columns.Add("Cantidad");
                foreach (ListViewItem l in lv_Detalle.Items)
                {
                    DataRow dr = msj.dt_Productos.NewRow();
                    dr[0] = l.SubItems[0].Text;
                    dr[1] = l.SubItems[2].Text;
                }
                send.EnviarMensaje(c.SerializarObj(msj));
                MessageBox.Show("Eliminado");
                Ventas ventas = Ventas.getInstance();
                foreach (DataRow dr in ventas.dt_Ventas.Rows)// ARREGLAR
                {
                    if (dr[2].ToString() == lb_Ticket.Text)
                    {
                        ventas.dt_Ventas.Rows.Remove(dr);
                    }
                }
                foreach (ListViewItem l in Ventas_F.lv_Ventas.Items)
                {
                    if (l.SubItems[1].Text == lb_Ticket.Text)
                        l.Remove();
                }
                this.Close();
            }
            if (btn_Guardar == sender)
            {
                Mensaje msj = new Mensaje();
                msj.op = 8;
                msj.Correcto = Factura;
                msj.dt_Venta = new DataTable();
                msj.dt_Venta.Columns.Add("Codigo");
                msj.dt_Venta.Columns.Add("Descripcion");
                msj.dt_Venta.Columns.Add("Cantidad");
                msj.dt_Venta.Columns.Add("Precio Unitario");
                msj.dt_Venta.Columns.Add("Precio Total");
                msj.Monto = total;
                msj.dt_Aux = dt_Aux;
                if (total == totalinicial)
                {
                    msj.CajaActual = datos.CajaActual;
                }
                else
                {
                    datos.CajaActual = datos.CajaActual-(totalinicial - total);
                    msj.CajaActual = datos.CajaActual;
                }
                msj.dt_Productos = dt_Productos;
                msj.N_Ticket = Convert.ToInt32(lb_Ticket.Text);
                msj.Porcentaje = Convert.ToInt32(txt_Descuento.Text);
                foreach(ListViewItem l in lv_Detalle.Items)
                {
                    DataRow dr = msj.dt_Venta.NewRow();
                    dr[0] = l.SubItems[0].Text;
                    dr[1] = l.SubItems[1].Text;
                    dr[2] = l.SubItems[2].Text;
                    dr[3] = l.SubItems[3].Text;
                    dr[4] = (Convert.ToDouble(l.SubItems[3].Text) *Convert.ToInt32(l.SubItems[2].Text));
                }
                try
                {
                    send.EnviarMensaje(c.SerializarObj(msj));
                }
                catch
                {
                    MessageBox.Show("Error 103 no se pudo guardar los cambios ");
                }
                MessageBox.Show("Cambios Efectuados");
                this.Close();
            }
            if (btn_Cantidad == sender)
            {
                if (txt_Cantidad.Text == "" || txt_Cantidad.Text == "0")
                {
                    MessageBox.Show("Valor de cantidad no valido");
                }
                else
                {

                    foreach (ListViewItem l in lv_Detalle.SelectedItems)
                    {
                        DataRow dr = dt_Productos.NewRow();
                        dr[0] = l.SubItems[0].Text;
                        dr[1] = txt_Cantidad.Text;
                        dt_Productos.Rows.Add(dr);
                        double total1 = Convert.ToDouble(l.SubItems[4].Text);
                        l.SubItems[2].Text = (Convert.ToInt32(l.SubItems[2].Text) - Convert.ToInt32(txt_Cantidad.Text)).ToString();
                        l.SubItems[4].Text = (Convert.ToInt32(l.SubItems[2].Text) * Convert.ToDouble(l.SubItems[3].Text)).ToString();
                        l.SubItems[4].Text = CalcularDescuento(Convert.ToDouble(l.SubItems[4].Text), Convert.ToInt32(txt_Descuento.Text)).ToString();
                        total = total - (total1 - Convert.ToDouble(l.SubItems[4].Text));
                    }
                }
            }
        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (txt_Descuento == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    if (Convert.ToInt32(txt_Descuento.Text) < 0)
                    {
                        MessageBox.Show("Descuento no puede ser negativo");
                    }
                    else
                    {
                        foreach (ListViewItem l in lv_Detalle.SelectedItems)
                        {
                            l.SubItems[4].Text = (Convert.ToDouble(l.SubItems[4].Text) - (Convert.ToDouble(l.SubItems[4].Text) * Convert.ToDouble(txt_Descuento.Text) / 100)).ToString();
                        }
                    }
                }
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
            if (txt_Cantidad == sender)
            {
                if (Convert.ToInt32(txt_Cantidad.Text) < 0) { MessageBox.Show("No puede ser negativo"); }
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
        private double CalcularDescuento(double Precio , int Porcentaje)
        {
            return (Precio - (Precio * Porcentaje / 100));
        }
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
