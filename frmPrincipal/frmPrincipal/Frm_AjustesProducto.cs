using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace frmPrincipal
{
    public partial class Frm_AjustesProducto : Form
    {
        private Conexion conexion = Conexion.getintance();
        private Hashtable hashtable = new Hashtable();
        private DataTable dtProductos;
        private Hashtable hs_Productos;
        public Frm_AjustesProducto()
        {
            InitializeComponent();
            hs_Productos = new Hashtable();
            hs_Productos = conexion.LLenarComboBox("Select *from Productos;", "Cod_Producto", "Porcentaje_Ganancia");
            hashtable = conexion.LLenarComboBox("SELECT * FROM Proveedores;", "Nombre_RazonSocial", "Cod_Proveedor");
            UpdateTabla();
        }
        private void UpdateTabla()
        {
            lv_AjusteProducto.Items.Clear();
            OleDbDataReader DBdatareader = conexion.ConsultaDatos("SELECT * FROM Productos;");
            while (DBdatareader.Read())
            {
                ListViewItem item = new ListViewItem(DBdatareader["Cod_Producto"].ToString());
                item.SubItems.Add(DBdatareader[1].ToString());
                item.SubItems.Add(DBdatareader["Precio_Costo"].ToString());
                item.SubItems.Add(DBdatareader["Precio_Unitario"].ToString());
                item.SubItems.Add(hashtable[DBdatareader[9].ToString()].ToString());
                item.SubItems.Add(DBdatareader[11].ToString());
                lv_AjusteProducto.Items.Add(item);
            }
            dtProductos = new DataTable();
            foreach (ColumnHeader chtext in lv_AjusteProducto.Columns)
            {
                dtProductos.Columns.Add(chtext.Text);
            }
            foreach (ListViewItem item in lv_AjusteProducto.Items)
            {
                DataRow row = dtProductos.NewRow();
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    row[i] = item.SubItems[i].Text;
                }
                dtProductos.Rows.Add(row);
            }
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Aceptar == sender)
            {
                if (txt_CostoPorcentaje.Text == "")
                {
                    MessageBox.Show("Porfavor ingrese el porcentaje a subir los articulos");
                }
                else
                {
                    CambiarCosto();
                }
            }
            if (btn_Salir == sender)
            {
                this.Close();
            }
        }

        private void TxtChange(object sender, EventArgs e)
        {
            if (txt_Proveedor == sender)
            {
                lv_AjusteProducto.Items.Clear();
                foreach (DataRow l in dtProductos.Rows)
                {
                    if (CompareString(txt_Proveedor.Text, l[4].ToString()))
                    {
                        ListViewItem listitem = new ListViewItem(l[0].ToString());
                        listitem.SubItems.Add(l[1].ToString());
                        listitem.SubItems.Add(l[2].ToString());
                        listitem.SubItems.Add(l[3].ToString());
                        listitem.SubItems.Add(l[4].ToString());
                        listitem.SubItems.Add(l[5].ToString());
                        lv_AjusteProducto.Items.Add(listitem);
                    }
                }
            }
            if (txt_Rubro == sender)
            {
                lv_AjusteProducto.Items.Clear();
                foreach (DataRow l in dtProductos.Rows)
                {
                    if (CompareString(txt_Rubro.Text, l[5].ToString()))
                    {
                        ListViewItem listitem = new ListViewItem(l[0].ToString());
                        listitem.SubItems.Add(l[1].ToString());
                        listitem.SubItems.Add(l[2].ToString());
                        listitem.SubItems.Add(l[3].ToString());
                        listitem.SubItems.Add(l[4].ToString());
                        listitem.SubItems.Add(l[5].ToString());
                        lv_AjusteProducto.Items.Add(listitem);
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
        private void CambiarCosto()
        {
            double venta = 0;
            double costo = 0;
            foreach(ListViewItem lv in lv_AjusteProducto.SelectedItems)
            {
                costo = Convert.ToDouble(lv.SubItems[2].Text);
                costo = costo + costo * Convert.ToInt32(txt_CostoPorcentaje.Text) / 100;
                venta = costo + costo * Convert.ToDouble(hs_Productos[lv.SubItems[0].Text])/100;
                conexion.InsertarDatos("Update Productos set Precio_Costo = '" + costo + "', Precio_Unitario = '" + venta + "' where Cod_Producto = "+Convert.ToInt64(lv.SubItems[0].Text)+"");
            }
            MessageBox.Show("Costo y Precio de venta actualizado al porcentaje de ganancia del producto");
            UpdateTabla();
        }

        private void txt_CostoPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

    }
}
