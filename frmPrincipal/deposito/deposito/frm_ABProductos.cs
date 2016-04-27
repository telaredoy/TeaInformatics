using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Serial;

namespace deposito
{
    public partial class frm_ABProductos : Form
    {
        private Engine engine = Engine.getInstance();
        private Hashtable hs_Proveedores;
        private Hashtable proveedores;
        private bool Activated_ = true;
        public frm_ABProductos()
        {
            InitializeComponent();
            CargarHashTable();
            CargarListView();
        }
        private void CargarListView()
        {
            proveedores = new Hashtable();
            foreach (DataRow dr in engine.getDatos().getProveedores().Rows)
            {
                proveedores.Add(dr[0].ToString(), dr[1].ToString());
            }
            foreach (DataRow dr in engine.getDatos().getProductos().Rows)
            {
                ListViewItem l = new ListViewItem(dr[0].ToString());
                l.SubItems.Add(dr[1].ToString());
                l.SubItems.Add(proveedores[dr[3].ToString()].ToString());
                lv_Productos.Items.Add(l);
            }
        }
        private void CargarHashTable()
        {           
            hs_Proveedores = new Hashtable();
            foreach (DataRow dr in engine.getDatos().getProveedores().Rows)
            {
                hs_Proveedores.Add(dr[0].ToString(), dr[1].ToString());
            }
            BindingSource ls = new BindingSource();
            ls.DataSource = this.hs_Proveedores;
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "value";
            comboBox1.ValueMember = "key";
        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (txt_Buscador == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    lv_Productos.Items.Clear();
                    foreach (DataRow dr in engine.getDatos().getProductos().Rows)
                    {
                        if (dr[0].ToString() == txt_Buscador.Text)
                        {
                            ListViewItem l = new ListViewItem(dr[0].ToString());
                            l.SubItems.Add(dr[1].ToString());
                            l.SubItems.Add(proveedores[dr[3].ToString()].ToString());
                            lv_Productos.Items.Add(l);
                        }
                    }
                }
                SoloNumeros(e);
            }
            if (txt_Codigo == sender) 
            {
                SoloNumeros(e);
            }
            if (txt_Cantidad == sender)
            {
                SoloNumeros(e);
            }
            if (txt_CantP == sender)
            {
                SoloNumeros(e);
            }
            if (txt_StockCritico == sender)
            {
                SoloNumeros(e);
            }
            if (txt_Ganancia == sender)
            {
                TextBoxComas(e, txt_Ganancia);
            }
            if (txt_PrecioC == sender)
            {
                TextBoxComas(e, txt_PrecioC);
            }
            if (txt_PrecioV == sender)
            {
                TextBoxComas(e, txt_PrecioV);
            }
        }
        private void TextBoxComas(KeyPressEventArgs e, TextBox txt)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Oemcomma && (e.KeyChar != (char)Keys.OemPeriod)))
            {
                if (e.KeyChar == '.')
                {
                    if (!(txt.Text.IndexOf('.') == -1)) //Limitar a 1 punto por TextBox
                    {
                        e.Handled = true;
                        return;
                    }
                    e.Handled = false;
                    return;
                }
                if (e.KeyChar == ',')
                {
                    if (!(txt.Text.IndexOf('.') == -1)) //Limitar a 1 punto por TextBox
                    {
                        e.Handled = true;
                        return;
                    }
                    txt.Text = txt.Text + ".";
                    e.Handled = true;
                    txt.Select(txt.Text.IndexOf('.') + 1, txt.TextLength);
                }
                else
                {
                    e.Handled = true; //@Author Tibe 18/01/2016 El handle True nega el char ingresado si es no es un numero del 0 - 9
                }
            }
        }
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void txt_Codigo_Leave(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "")
            {
                Activated_ = true;
            }
            if (Activated_)
            {
                string Texto = "";
                foreach (DataRow dr in engine.getDatos().getProductos().Rows)
                {
                    if (dr[0].ToString() == txt_Codigo.Text)
                    {
                        if (hs_Proveedores.ContainsKey(dr[3].ToString()))
                        {
                            Texto = Texto + hs_Proveedores[dr[3].ToString()] + ",";
                            hs_Proveedores.Remove(dr[3].ToString());
                        }
                    }
                }
                if (Texto != "")
                {
                    DialogResult dr = MessageBox.Show("¡El codigo de producto ya existe! de los siguientes proveedores: \n " + Texto + " \n Verifica que no sea un codigo clonado y pide genearar un nuevo codigo con el administador \n ¿Deseas cargar el mismo producto existende con diferente proveedor?", "Alerta", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            if (hs_Proveedores.Count > 0)
                            {
                                BindingSource ls = new BindingSource();
                                ls.DataSource = this.hs_Proveedores;
                                comboBox1.DataSource = ls;
                                comboBox1.DisplayMember = "value";
                                comboBox1.ValueMember = "key";
                                comboBox1.Text = "seleccione un proveedor";
                            }
                            else
                            {
                                MessageBox.Show("No existe ningun otro proveedor que no traiga este producto agregue un nuevo proveedor");
                            }
                            Mensaje msj = new Mensaje();
                            msj.op = 19;
                            msj._Mensaje = txt_Codigo.Text;
                            engine.EnviarMensaje(msj);
                            break;
                        case DialogResult.No:
                            txt_Codigo.Text = "";
                            break;
                    }
                }
                else
                {
                    if (txt_Codigo.Text != "")
                    {
                        BindingSource ls = new BindingSource();
                        ls.DataSource = this.hs_Proveedores;
                        comboBox1.DataSource = ls;
                        comboBox1.DisplayMember = "value";
                        comboBox1.ValueMember = "key";
                        MessageBox.Show("Selecciona un proveedor del producto sino existe asigna un nuevo proveedor");               
                    }
                }
            }
        }
        private void EstadosTextBox(bool p)
        {
            Activated_ = false;
            txt_Codigo.Enabled = p;
            txt_CantP.Enabled = p;
            txt_Cantidad.Enabled = p;
            txt_Descripcion.Enabled = p;
            txt_DesTicket.Enabled = p;
            txt_Ganancia.Enabled = p;
            txt_PrecioC.Enabled = p;
            txt_PrecioV.Enabled = p;
            txt_Rubro.Enabled = p;
            txt_StockCritico.Enabled = p;
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Refrescar == sender)
            {
                lv_Productos.Items.Clear();
                CargarListView();
            }
            if (btn_NuevoProveedor == sender)
            {
                engine.NuevoProveedor1 = new frm_NuevoProveedor();
                engine.NuevoProveedor1.ShowDialog();
            }
            if (btn_Cancelar == sender)
            {
                EstadosTextBox(true);
                txt_Cantidad.Clear();
                txt_CantP.Clear();
                txt_CantT.Clear();
                txt_Codigo.Clear();
                txt_Descripcion.Clear();
                txt_DesTicket.Clear();
                txt_Ganancia.Clear();
                txt_PrecioC.Clear();
                txt_PrecioV.Clear();
                txt_Rubro.Clear();
                txt_StockCritico.Clear();
                txt_Codigo.Select();
                CargarHashTable();
            }
            if (btn_Cargar == sender)
            {
                if (comboBox1.Text != "" && txt_Cantidad.Text != "" && txt_CantP.Text != "" && txt_CantT.Text != "" && txt_Codigo.Text != "" && txt_Descripcion.Text != "" && txt_DesTicket.Text != "" && txt_Ganancia.Text != "" && txt_PrecioC.Text != "" && txt_PrecioV.Text !="" && txt_Rubro.Text != "" && txt_StockCritico.Text != "" )
                {
                    Mensaje msj = new Mensaje();
                    msj.op = 20;
                    msj.producto = new Serial.Producto();
                    msj.producto.Codigo = Convert.ToInt64(txt_Codigo.Text);
                    msj.producto.Descripcion = txt_Descripcion.Text;
                    msj.producto.DescripcionTicket = txt_DesTicket.Text;
                    msj.producto.Cantidad = Convert.ToInt32(txt_Cantidad.Text);
                    msj.producto.Cantidad_Particionable = Convert.ToInt32(txt_CantP.Text);
                    msj.producto.Cantidad_Total = Convert.ToInt32(txt_CantT.Text);
                    msj.producto.PrecioCosto = Convert.ToDouble(txt_PrecioC.Text);
                    msj.producto.PrecioVenta = Convert.ToDouble(txt_PrecioV.Text);
                    msj.producto.Ganancia = Convert.ToDouble(txt_Ganancia.Text);
                    msj.producto.StockCritico = Convert.ToInt32(txt_StockCritico.Text);
                    msj.producto.Rubro = txt_Rubro.Text;
                    msj.IdCliente = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                    engine.EnviarMensaje(msj);
                    MessageBox.Show("Cargado!");
                    //Limpieza
                    EstadosTextBox(true);
                    txt_Cantidad.Clear();
                    txt_CantP.Clear();
                    txt_CantT.Clear();
                    txt_Codigo.Clear();
                    txt_Descripcion.Clear();
                    txt_DesTicket.Clear();
                    txt_Ganancia.Clear();
                    txt_PrecioC.Clear();
                    txt_PrecioV.Clear();
                    txt_Rubro.Clear();
                    txt_StockCritico.Clear();
                    txt_Codigo.Select();
                    CargarHashTable();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos para cargar el producto");
                }
            }
            if (btn_Elminar == sender)
            {
                if (lv_Productos.SelectedItems.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("¿Estas seguro que desea eliminar el producto?", "Alerta", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            ListViewItem l = lv_Productos.SelectedItems[0];
                            Mensaje msj = new Mensaje();
                            msj.op = 21;
                            msj.dt_Aux = new DataTable();
                            msj.dt_Aux.Columns.Add("d");
                            msj.dt_Aux.Columns.Add("f");
                            DataRow dtr = msj.dt_Aux.NewRow();
                            dtr[0] = l.Text;
                            foreach(DataRow dp in engine.getDatos().getProveedores().Rows)
                            {
                                if(l.SubItems[2].Text == dp[1].ToString())
                                {
                                    dtr[1] = dp[0].ToString();
                                    break;
                                }   
                            }
                            msj.dt_Aux.Rows.Add(dtr);
                            engine.EnviarMensaje(msj);
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto");
                }
            }
        }
        public void Actualizar()
        {
            lv_Productos.Items.Clear();
            CargarListView();
            CargarHashTable();
        }
        internal void CargarProducto(Serial.Producto producto)
        {
            txt_Cantidad.Text = producto.Cantidad.ToString();
            txt_CantP.Text = producto.Cantidad_Particionable.ToString();
            txt_CantT.Text = producto.Cantidad_Total.ToString();
            txt_Descripcion.Text = producto.Descripcion;
            txt_DesTicket.Text = producto.DescripcionTicket;
            txt_Ganancia.Text = producto.Ganancia.ToString();
            txt_PrecioC.Text = producto.PrecioCosto.ToString();
            txt_PrecioV.Text = producto.PrecioVenta.ToString();
            txt_Rubro.Text = producto.Rubro;
            txt_StockCritico.Text = producto.StockCritico.ToString();
            EstadosTextBox(false);                     
        }
        private void txt_CantP_Leave(object sender, EventArgs e)
        {
            if (txt_Cantidad.Text != "")
            {
                txt_CantT.Text = (Convert.ToInt32(txt_Cantidad.Text) * Convert.ToInt32(txt_CantP.Text)).ToString();
            }
        }
        private void txt_Ganancia_Leave(object sender, EventArgs e)
        {
            if (txt_PrecioC.Text != "" && txt_Ganancia.Text != "")
            {
                txt_PrecioV.Text = Math.Round((Convert.ToDouble(txt_PrecioC.Text) + (Convert.ToDouble(txt_PrecioC.Text) * Convert.ToDouble(txt_Ganancia.Text) / 100)),2).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese el precio de costo y porcentaje de ganancia");
            }
        }
        private void txt_PrecioV_Leave(object sender, EventArgs e)
        {
            if (txt_PrecioC.Text != "" && txt_PrecioV.Text != "")
            {
                txt_Ganancia.Text = Math.Round(((((Convert.ToDouble(txt_PrecioV.Text)/(Convert.ToDouble(txt_PrecioC.Text)) -1) *100))), 2).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese el precio de costo y el precio de venta");
            }
        }
       
    }
}
