using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace frmPrincipal
{
    public partial class Venta : Form
    {
        private Conexion conexion = Conexion.getintance();
        private DataTable dt_Productos;
        private bool Cambios = false;
        private ListView _LvDetalle;
        private DataTable dt_Detalle;
        public Venta(int NTicket, string Cliente,string Fecha,double Total,string Descuento,ListView _LvDetalle)
        {
            InitializeComponent();
            this.dt_Detalle = new DataTable();
            dt_Detalle.Columns.Add("Ticket");
            dt_Detalle.Columns.Add("Codigo");
            dt_Detalle.Columns.Add("Cantidad");
            this._LvDetalle = _LvDetalle;
            lb_Ticket.Text = NTicket.ToString();
            lb_Cliente.Text = Cliente;
            lb_Fecha.Text = Fecha;
            dt_Productos = new DataTable();
            dt_Productos.Columns.Add("Codigo");
            dt_Productos.Columns.Add("Cantidad");
            lb_Total.Text = Total.ToString();
            double aux = 0;
            OleDbDataReader dr = conexion.ConsultaDatos("Select * FROM Detalle WHERE Cod_Detalle = "+NTicket+"");
            while(dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["Cod_Producto"].ToString());
                l.SubItems.Add(dr["Descripcion_Ticket"].ToString());
                l.SubItems.Add(dr["Cantidad"].ToString());
                l.SubItems.Add(dr["Precio_Unitario"].ToString());
                aux += Convert.ToInt32(dr["Cantidad"].ToString())*Convert.ToDouble(dr["Precio_Unitario"].ToString());
                l.SubItems.Add(dr["Precio_Total"].ToString());
                lv_Detalle.Items.Add(l);
            }
            lb_Descuento.Text = Descuento;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cambios)
            {
                MessageBox.Show("Si sale no se guardaran los cambios efectuados");
            }
            else
            {
                this.Close();
            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Borrar == sender)
            {
                if (lv_Detalle.SelectedItems.Count > 0)
                {
                    ListViewItem l = lv_Detalle.SelectedItems[0];
                    DataRow dr = dt_Productos.NewRow();
                    dr[0] = l.SubItems[0].Text;
                    dr[1] = l.SubItems[2].Text;
                    dt_Productos.Rows.Add(dr);
                    l.Remove();
                    CalcularTotal();
                    Cambios = true;
                }
                else
                {
                    MessageBox.Show("Seleccione un campo a borrar");
                }
            }
            if (btn_Salir == sender)
            {
                if(Cambios)
                {
                    MessageBox.Show("Si sale no se guardaran los cambios efectuados");
                }
                else
                {
                    this.Close();
                }
            }
            if (btn_Guardar == sender)
            {
                foreach (DataRow dr in dt_Productos.Rows)
                {
                    conexion.CargarStock(Convert.ToInt32(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()));
                }
                foreach (DataRow dr in dt_Detalle.Rows)
                {
                    if (dr[1].ToString() == "0")
                    {
                        conexion.InsertarDatos("Delete from Detalle where Cod_Detalle =" + Convert.ToInt32(lb_Ticket.Text) + " and Cod_Producto = " + Convert.ToInt64(dr[2].ToString()) + "");
                    }
                    else
                    {
                        conexion.InsertarDatos("update Detalle Set Cantidad = " + Convert.ToInt32(dr[1].ToString()) + " where Cod_Detalle =" + Convert.ToInt32(dr[0].ToString()) + " and Cod_Producto = " + Convert.ToInt64(dr[2].ToString()) + "");
                    }
                }
                Cambios = false;
            }
            if (btn_Descontar == sender)
            {
                if (txt_Cantidad.Text != "" && txt_Cantidad.Text != "0")
                {
                    if (lv_Detalle.SelectedItems.Count > 0)
                    {
                        ListViewItem l = lv_Detalle.SelectedItems[0];
                        if (Convert.ToInt32(txt_Cantidad.Text) > Convert.ToInt32(l.SubItems[2].Text))
                        {
                            MessageBox.Show("Cantidad a devolver mayor a la impresa en ticket");
                        }
                        else
                        {
                            Cambios = true;
                            DataRow dr = dt_Productos.NewRow();
                            dr[0] = l.SubItems[0].Text;
                            dr[1] = txt_Cantidad.Text;
                            dt_Productos.Rows.Add(dr);
                            dr = dt_Detalle.NewRow();
                            dr[0] = lb_Ticket.Text;
                            dr[1] = l.SubItems[0].Text;
                            dr[2] = txt_Cantidad.Text;
                            dt_Detalle.Rows.Add(dr);
                            l.SubItems[2].Text = (Convert.ToInt32(l.SubItems[2].Text) - Convert.ToInt32(txt_Cantidad.Text)).ToString();
                            l.SubItems[4].Text = CalcularDescuento(Convert.ToDouble(((Convert.ToInt32(l.SubItems[2].Text) * Convert.ToDouble(l.SubItems[3].Text)))), Convert.ToInt32(lb_Descuento.Text)).ToString();
                            if (l.SubItems[2].Text == "0")
                            {
                                l.Remove();
                            }
                            CalcularTotal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un campo");
                    }
                }
                else
                {
                    MessageBox.Show("Valor de cantidad no valido");
                }

            }
            if (btn_Eliminar == sender)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar el ticket?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.InsertarDatos("Delete from Logs where Cod_Ticket = " + Convert.ToInt32(lb_Ticket.Text) + "");
                    conexion.InsertarDatos("Delete from Ticket where Cod_Ticket = " + Convert.ToInt32(lb_Ticket.Text) + "");
                    conexion.InsertarDatos("Delete *from Detalle where Cod_Detalle = " + Convert.ToInt32(lb_Ticket.Text) + "");
                    conexion.InsertarDatos("Delete *from Factura where Cod_Ticket = " + Convert.ToInt32(lb_Ticket.Text) + "");
                    MessageBox.Show("Ticket eliminado");
                    foreach (DataRow dr in dt_Productos.Rows)
                    {
                        conexion.CargarStock(Convert.ToInt32(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()));
                    }
                    foreach (ListViewItem l in _LvDetalle.Items)
                    {
                        if (l.SubItems[1].Text == lb_Ticket.Text)
                        {
                            l.Remove();
                        }
                    }
                    this.Close();     //do something
                }
            }
        }

        private void CalcularTotal()
        {
            double aux = 0;
            foreach (ListViewItem l in lv_Detalle.Items)
            {
                aux += Convert.ToDouble(l.SubItems[4].Text);
            }
            lb_Total.Text = aux.ToString();
        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }
        private double CalcularDescuento(double Precio, int Porcentaje)
        {
            return (Precio - (Precio * Porcentaje / 100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
