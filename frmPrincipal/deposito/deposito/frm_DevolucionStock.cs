using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serial;
using System.Collections;
using System.Threading;

namespace deposito
{
    public partial class frm_DevolucionStock : Form
    {
        Engine engine = Engine.getInstance();
        private DataTable dtAuxiliar;
        private Hashtable hs_Proveedores;
        private Hashtable hs_Productos;
        private Hashtable hs_Precios;
        public frm_DevolucionStock()
        {
            InitializeComponent();
            dtAuxiliar = new DataTable();
            hs_Productos = new Hashtable();
            dtAuxiliar.Columns.Add("Cod");
            dtAuxiliar.Columns.Add("cant");
            hs_Proveedores = new Hashtable();
            foreach (DataRow dr in engine.getDatos().getProveedores().Rows)
            {
                hs_Proveedores.Add(dr[0].ToString(), dr[1].ToString());
            }
            BindingSource ls = new BindingSource();
            ls.DataSource = this.hs_Proveedores;
            cb_Proveedor.DataSource = ls;
            cb_Proveedor.DisplayMember = "value";
            cb_Proveedor.ValueMember = "key";
            foreach (DataRow dr in engine.getDatos().getProductos().Rows)
            {
                if (hs_Productos.ContainsKey(dr[0].ToString()))
                {
                    continue;
                }
                else
                {
                    hs_Productos.Add(dr[0].ToString(), dr[1].ToString());
                }
            }
            Mensaje msj = new Mensaje();
            msj.op = 25;
            engine.EnviarMensaje(msj);
        }
        public void CargarDatatable(DataTable dt)
        {
            hs_Precios = new Hashtable();
            foreach (DataRow dr in dt.Rows)
            {
                if (hs_Precios.ContainsKey(dr[0].ToString()))
                {
                    continue;
                }
                else
                {
                    hs_Precios.Add(dr[0].ToString(), dr[1].ToString());
                }
            }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            if (btn_agregar == sender)
            {
                if (txt_Cant.Text != "" && txt_Codigo.Text != "")
                {
                    ListViewItem l = new ListViewItem(txt_Codigo.Text);
                    l.SubItems.Add(hs_Productos[txt_Codigo.Text].ToString());
                    l.SubItems.Add(txt_Cant.Text);
                    lv_Detalle.Items.Add(l);
                    label_Monto.Text = (Convert.ToDouble(label_Monto.Text) + Convert.ToDouble(hs_Precios[txt_Codigo.Text].ToString())).ToString();
                    txt_Cant.Clear();
                    txt_Codigo.Clear();
                    txt_Codigo.Select();
                }
                else
                {
                    MessageBox.Show("Falta completar algun campo");
                }
            }
            if (button1 == sender)
            {
                foreach (ListViewItem l in lv_Detalle.SelectedItems)
                {
                    l.Remove();
                }
                txt_Codigo.Select();
            }
            if (btn_Cargar == sender)
            {
                foreach (ListViewItem l in lv_Detalle.Items)
                {
                    DataRow dr = dtAuxiliar.NewRow();
                    dr[0] = l.SubItems[0].Text;
                    dr[1] = l.SubItems[2].Text;
                    dtAuxiliar.Rows.Add(dr);
                }
                Mensaje msj = new Mensaje();
                msj.op = 26;
                msj.dt_Productos = dtAuxiliar;
                msj._Mensaje = textBox1.Text;
                msj.Monto = Convert.ToDouble(label_Monto.Text);
                msj.IdCliente = Convert.ToInt32(cb_Proveedor.SelectedValue.ToString());
                engine.EnviarMensaje(msj);
                MessageBox.Show("Cargado con exito!");
                this.Close();
            }
        }
    }
}
