using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    public partial class frm_FiltroProductos : Form
    {
        private Datos d;
        private ListView lv_Detalle;
        private Label total;
        private frm_Terminal t;
        public frm_FiltroProductos(Datos datos , ListView lv_Detalle, Label total,frm_Terminal t)
        {
            InitializeComponent();
            this.d = datos;
            this.t = t;
            this.total = total;
            this.lv_Detalle = lv_Detalle;
            CargarDatos();
        }
        private void CargarDatos()
        {
            foreach (DataRow dr in d.dt_Productos.Rows)
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv_Productos.Items.Add(lv);
            }
        }
        private void TextChange(object sender, EventArgs e)
        {
            if (txt_Filtro == sender)
            {
                lv_Productos.Items.Clear();
                foreach (DataRow dr in d.dt_Productos.Rows)
                {
                    if (CompareString(txt_Filtro.Text, dr[1].ToString()))
                    {
                        ListViewItem lv = new ListViewItem(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[2].ToString());
                        lv_Productos.Items.Add(lv);
                    }
                }
            }
        }
        private bool CompareString(string a, string b)
        {
            int contador_I = 0;
            foreach (char c in a)
            {
                try
                {
                    if (!(Char.ToLower(c) == Char.ToLower(b[contador_I])))
                    {
                        return false;
                    }
                    contador_I++;
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        private List<string> RecolectarString(string txt)
        {
            List<string> v = new List<string> { };
            string aux = "";
            foreach (char x in txt)
            {
                if (x == ' ')
                {
                    v.Add(aux);
                    aux = "";
                    continue;
                }
                aux += x;
            }
            v.Add(aux);
            return v;
        }
        private void DobleClickEvent(object sender, EventArgs e)
        {
            foreach (ListViewItem l in lv_Productos.SelectedItems)
            {
                t.Cod = l.SubItems[0].Text;
                t.Desc = l.SubItems[1].Text;
                t.PrecioVenta = l.SubItems[2].Text;
                
                txt_Cantidad.Enabled = true;
                txt_Cantidad.Select();
            }
        }
        private void ClickBotton(object sender, EventArgs e)
        {
            if (btn_Salir == sender)
            {
                this.Close();
            }
            if (btn_Cargar == sender)
            {
                if (lv_Productos.SelectedItems.Count > 0)
                {
                    if (txt_Cantidad.Text == "" || txt_Cantidad.Text == "0" || txt_Cantidad.Text == " ")
                    {
                        MessageBox.Show("Campo de cantidad con valor no valido");
                    }
                    else
                    {

                        t.Carga(Convert.ToInt32(txt_Cantidad.Text));
                        t.Sumar();
                        t.CentrarFoco();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se selecciono ningun producto");
                }
            }
        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (txt_Filtro == sender)
            {
                if (e.KeyChar == (Char)Keys.Down || e.KeyChar == (Char)Keys.Enter)
                {
                    if (lv_Productos.Items.Count > 0)
                    {
                        lv_Productos.Items[0].Selected = true;
                        lv_Productos.Select();
                    }
                }
            }
            if (lv_Productos == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    foreach (ListViewItem l in lv_Productos.SelectedItems)
                    {
                        t.Cod = l.SubItems[0].Text;
                        t.Desc = l.SubItems[1].Text;
                        t.PrecioVenta = l.SubItems[2].Text;
                    }
                
                    txt_Cantidad.Select();
                    txt_Cantidad.Enabled = true;
                }
            }
            if (txt_Cantidad == sender)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;

                    if (e.KeyChar == (Char)Keys.Enter)
                    {
                        if (txt_Cantidad.Text == "" || txt_Cantidad.Text == "0" || txt_Cantidad.Text == " ")
                        {
                            MessageBox.Show("Campo de cantidad con valor no valido");
                        }
                        else
                        {

                            t.Carga(Convert.ToInt32(txt_Cantidad.Text));
                            t.Sumar();
                            t.CentrarFoco();
                            this.Close();
                        }
                    }
                    return;
                }
            }
        }
        private double CalcularDescuento(double Precio, int Porcentaje)
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

    }
}
