using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
namespace frmPrincipal
{
    public partial class RegistroDeVentas : Form
    {
        private DataTable dt;
        private Conexion conexion = Conexion.getintance();
        ArrayList Tickets;
            
        public RegistroDeVentas()
        {
            InitializeComponent();
            dt = new DataTable();
            Tickets = new ArrayList();
            
            this.cb_Terminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ActualizarDatos();
            
        }
        private string ObtenerCliente(int idCliente)
        {
            string Nombre = "";
            OleDbDataReader dr = conexion.ConsultaDatos("Select * From Cliente where Cod_Cliente = "+idCliente+"");
            while (dr.Read())
            {
                Nombre = dr["Nombre_RazonSocial"].ToString();
            }
            return Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_NTicket.Text != "" && txt_NTicket.Text != "0")
            {
                lv_Ventas.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == txt_NTicket.Text)
                    {
                        ListViewItem l = new ListViewItem(dr[0].ToString());
                        l.SubItems.Add(dr[1].ToString());
                        l.SubItems.Add(dr[2].ToString());
                        l.SubItems.Add(dr[3].ToString());
                        l.SubItems.Add(dr[4].ToString());
                        l.SubItems.Add(dr[5].ToString());
                        l.SubItems.Add(dr[6].ToString());
                        lv_Ventas.Items.Add(l);
                    }
                }
            }
            else
            {
                MessageBox.Show("Numero de Ticket no valido");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            txt_NTicket.Text = "";
            cb_Terminal.Text = "";
        }

        private void btn_Terminal_Click(object sender, EventArgs e)
        {
            if (cb_Terminal.Text != "Seleccionar")
            {
                lv_Ventas.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[4].ToString() == cb_Terminal.Text)
                    {
                        ListViewItem l = new ListViewItem(dr[0].ToString());
                        l.SubItems.Add(dr[1].ToString());
                        l.SubItems.Add(dr[2].ToString());
                        l.SubItems.Add(dr[3].ToString());
                        l.SubItems.Add(dr[4].ToString());
                        l.SubItems.Add(dr[5].ToString());
                        l.SubItems.Add(dr[6].ToString());
                        lv_Ventas.Items.Add(l);
                    }
                }
            
            }
            else
            {
                MessageBox.Show("Seleccione una terminal");
            }
        }

        private void lv_Ventas_DoubleClick(object sender, EventArgs e)
        {
            if (lv_Ventas.SelectedItems.Count > 0)
            {
                foreach (ListViewItem l in lv_Ventas.SelectedItems)
                {
                    Venta venta = new Venta(Convert.ToInt32(l.SubItems[1].Text), l.SubItems[2].Text, l.SubItems[0].Text, Convert.ToDouble(l.SubItems[3].Text), l.SubItems[6].Text,lv_Ventas);
                    venta.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No se selecciono ningun ticket");
            }
        }
        private void ActualizarDatos()
        {
            dt = null;
            dt = new DataTable();
            Tickets.Clear();
            OleDbDataReader dr = conexion.ConsultaDatos("Select * From Ticket,Factura where Ticket.Cod_Ticket = Factura.Cod_Ticket");
            while (dr.Read())
            {

                ListViewItem l = new ListViewItem(dr["Factura.Fecha"].ToString());
                l.SubItems.Add(dr["Ticket.Cod_Ticket"].ToString());
                l.SubItems.Add(ObtenerCliente(Convert.ToInt32(dr["Cod_Cliente"].ToString())));
                l.SubItems.Add(dr["Factura.Total"].ToString());
                l.SubItems.Add(dr["Ticket.IDTerminal"].ToString());
                l.SubItems.Add(dr["Nota"].ToString());
                l.SubItems.Add(dr["Descuento"].ToString());
                Tickets.Add(dr["Ticket.Cod_Ticket"].ToString());
                lv_Ventas.Items.Add(l);
            }
            dr = conexion.ConsultaDatos("Select * From Ticket");
            while (dr.Read())
            {
                if (Tickets.Contains(dr["Cod_Ticket"].ToString()))
                {
                    continue;
                }
                ListViewItem l = new ListViewItem(dr["Fecha"].ToString());
                l.SubItems.Add(dr["Cod_Ticket"].ToString());
                l.SubItems.Add("Ticket en Negro");
                l.SubItems.Add(dr["Total"].ToString());
                l.SubItems.Add(dr["IDTerminal"].ToString());
                l.SubItems.Add(dr["Nota"].ToString());
                l.SubItems.Add(dr["Descuento"].ToString());
                lv_Ventas.Items.Add(l);
            }
            dt.Columns.Add("Fecha");
            dt.Columns.Add("NTicket");
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Total");
            dt.Columns.Add("Terminal");
            dt.Columns.Add("Nota");
            dt.Columns.Add("Descuento");
            foreach (ListViewItem item in lv_Ventas.Items)
            {
                DataRow dtr = dt.NewRow();
                dtr[0] = item.SubItems[0].Text;
                dtr[1] = item.SubItems[1].Text;
                dtr[2] = item.SubItems[2].Text;
                dtr[3] = item.SubItems[3].Text;
                dtr[4] = item.SubItems[4].Text;
                dtr[5] = item.SubItems[5].Text;
                dtr[6] = item.SubItems[6].Text;
                dt.Rows.Add(dtr);
            }
        }

        private void txt_NTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = false;
                if (txt_NTicket.Text != "" && txt_NTicket.Text != "0")
                {
                    lv_Ventas.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[1].ToString() == txt_NTicket.Text)
                        {
                            ListViewItem l = new ListViewItem(dr[0].ToString());
                            l.SubItems.Add(dr[1].ToString());
                            l.SubItems.Add(dr[2].ToString());
                            l.SubItems.Add(dr[3].ToString());
                            l.SubItems.Add(dr[4].ToString());
                            l.SubItems.Add(dr[5].ToString());
                            l.SubItems.Add(dr[6].ToString());
                            lv_Ventas.Items.Add(l);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Numero de Ticket no valido");
                }
            }
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
