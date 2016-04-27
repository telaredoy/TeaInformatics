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
namespace deposito
{
    public partial class frm_CargarStock : Form
    {
        private Datos datos = Datos.getDatos();
        private string codigo;
        private DataTable dt_Auxiliar;
        Class1 class1 = new Class1();
        Send send = Send.GetSend();
        private Hashtable hs_Productos;
        public frm_CargarStock()
        {
            InitializeComponent();
            dt_Auxiliar=new DataTable();
            dt_Auxiliar.Columns.Add("cod");
            dt_Auxiliar.Columns.Add("desc");
            dt_Auxiliar.Columns.Add("cant");                     
            CargarHashTable();
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Cancelarr == sender)
            {
                EstadoTextBox(true);
                ActualizarListView();
            }
            if (btn_Aceptar == sender)
            {
                Producto p = (Producto)hs_Productos[tb_Codigo.Text];
                DataRow dtrow = dt_Auxiliar.NewRow();
                dtrow[0] = codigo;
                dtrow[1] = p.Descripcion;
                dtrow[2] = (p.Cantidad + Convert.ToInt32(tb_Cantidad.Text)).ToString();
                dt_Auxiliar.Rows.Add(dtrow);
                p.Cantidad += Convert.ToInt32(tb_Cantidad.Text);
                lb_Cantidad.Text = dt_Auxiliar.Rows.Count.ToString();
                ActualizarListView();
                LimpiarCampos();
            }
            if (btn_Salir == sender)
            {
                if (lb_Cantidad.Text != "0") 
                {
                    DialogResult dr = MessageBox.Show("¿Está seguro que desea salir sin guardar cambios?",
                      "Alerta", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes: this.Close(); break;
                        case DialogResult.No: break;
                    }
                }
                else
                {
                    this.Close();
                }
                
            }
            if (btn_Guardar == sender)
            {
                try
                {
                    Mensaje mensaje = new Mensaje();
                    mensaje.op = 18;
                    mensaje.dt_Aux = dt_Auxiliar;
                    send.EnviarMensaje(class1.SerializarObj(mensaje));
                    dt_Auxiliar = new DataTable();
                    dt_Auxiliar.Columns.Add("cod");
                    dt_Auxiliar.Columns.Add("des");
                    dt_Auxiliar.Columns.Add("cant");
                    lb_Cantidad.Text = dt_Auxiliar.Rows.Count.ToString();
                    MessageBox.Show("Guardados correctamente");
                }
                catch
                {
                    MessageBox.Show("Error al guardar datos!");
                }
            }
        }
        private void EstadoTextBox(bool p)
        {
            tb_Codigo.Enabled = p;
            tb_Descripcion.Enabled = p;
        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (tb_Cantidad == sender)
            {
                if (e.KeyChar == (char)Keys.Enter) 
                {
                    if (tb_Cantidad.Text != "" && tb_Cantidad.Text != "0")
                    {
                        Producto p = (Producto)hs_Productos[tb_Codigo.Text];
                        DataRow dtrow = dt_Auxiliar.NewRow();
                        dtrow[0] = codigo;
                        dtrow[1] = p.Descripcion;
                        dtrow[2] = (p.Cantidad + Convert.ToInt32(tb_Cantidad.Text)).ToString();
                        dt_Auxiliar.Rows.Add(dtrow);
                        p.Cantidad += Convert.ToInt32(tb_Cantidad.Text);
                        ActualizarListView();
                        LimpiarCampos();
                        lb_Cantidad.Text = dt_Auxiliar.Rows.Count.ToString();
                        EstadoTextBox(true);
                    }
                }
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
            if (tb_Codigo == sender)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (tb_Codigo.Text == "")
                    {
                        MessageBox.Show("Ingrese un código");
                    }
                    else
                    {
                        lv_productos.Items.Clear();
                        foreach (DictionaryEntry dc in hs_Productos)
                        {
                            if (tb_Codigo.Text == dc.Key.ToString())
                            {
                                Producto p = (Producto)dc.Value;
                                ListViewItem lvitem = new ListViewItem(dc.Key.ToString());
                                lvitem.SubItems.Add(p.Descripcion);
                                lvitem.SubItems.Add(p.Cantidad.ToString());
                                lv_productos.Items.Add(lvitem);
                                tb_Descripcion.Text = p.Descripcion;
                                tb_Cantidad.Select();
                                EstadoTextBox(false);
                                codigo = dc.Key.ToString();
                                break;
                            }                            
                        }
                    }
                }
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
            if (tb_Descripcion == sender)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (tb_Descripcion.Text == "")
                    {
                        MessageBox.Show("Ingrese una Descripción");
                    }
                    else
                    {
                        lv_productos.Items.Clear();
                        foreach (DictionaryEntry dc in hs_Productos)
                        {
                            Producto p = (Producto)dc.Value;
                            foreach (string x in RecolectarString(p.Descripcion))
                            {
                                if (CompareString(tb_Descripcion.Text, x))
                                {
                                    ListViewItem lvitem = new ListViewItem(dc.Key.ToString());
                                    lvitem.SubItems.Add(p.Descripcion);
                                    lvitem.SubItems.Add(p.Cantidad.ToString());
                                    lv_productos.Items.Add(lvitem);
                                    tb_Codigo.Text = dc.Key.ToString();
                                    codigo = dc.Key.ToString();
                                }

                            }
                        }
                        if (lv_productos.Items.Count > 2)
                        {
                            MessageBox.Show("Seleccione un producto");
                        }
                        else
                        {
                            EstadoTextBox(false);
                            tb_Cantidad.Select();
                        }
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
        private void DoubleClickEvent(object sender, EventArgs e)
        {
            ListViewItem l = lv_productos.SelectedItems[0];
            tb_Codigo.Text = l.SubItems[0].Text;
            tb_Descripcion.Text = l.SubItems[1].Text;
            tb_Cantidad.Select();
            EstadoTextBox(false);
        }
        private void CargarHashTable()
        {
            hs_Productos = new Hashtable();
            lv_productos.Items.Clear();
            foreach (DataRow dtrow in datos.getProductos().Rows)
            {
                Producto p = new Producto();
                p.Descripcion = dtrow[1].ToString();
                p.Cantidad = Convert.ToInt32(dtrow[2].ToString());
                if (hs_Productos.ContainsKey(dtrow[0].ToString()))
                {
                    continue;
                }
                else
                {
                    hs_Productos.Add(dtrow[0], p);
                }
            }
            foreach (DictionaryEntry de in hs_Productos)
            {
                Producto p = (Producto)de.Value;
                ListViewItem lvitem = new ListViewItem(de.Key.ToString());
                lvitem.SubItems.Add(p.Descripcion);
                lvitem.SubItems.Add(p.Cantidad.ToString());
                lv_productos.Items.Add(lvitem);
            }
        }
        private void ActualizarListView()
        {
            lv_productos.Items.Clear();
            foreach (DictionaryEntry de in hs_Productos)
            {
                Producto p = (Producto)de.Value;
                ListViewItem lvitem = new ListViewItem(de.Key.ToString());
                lvitem.SubItems.Add(p.Descripcion);
                lvitem.SubItems.Add(p.Cantidad.ToString());
                lv_productos.Items.Add(lvitem);
            }
        }
        private void LimpiarCampos()
        {
            tb_Cantidad.Text = "";
            tb_Codigo.Text = "";
            tb_Descripcion.Text = "";
        }
    }
}
