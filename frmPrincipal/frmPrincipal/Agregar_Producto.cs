using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace frmPrincipal
{
    public partial class Agregar_Producto : Form
    {
        private Conexion conexion = Conexion.getintance();
        private Hashtable Rubros;
        private Hashtable Proveedores_Lista;
        DataTable dtProductos;
        private Int64 id_tabla = 0;
        private Hashtable ListaProductos;
        public Agregar_Producto()
        {
            InitializeComponent();
            CargarComboBox();
            CargarListView();
            CargarProductos();
        }
        private void Event_TextChange(object sender, EventArgs e)
        {
            if (txt_filtro == sender)
            {
                lv_productos.Items.Clear();
                int n;
                bool isNumeric = int.TryParse(txt_filtro.Text, out n);
                if(isNumeric)
                {
                    foreach (DataRow l in dtProductos.Rows)
                    {
                        if (CompareString(txt_filtro.Text, l[0].ToString()))
                        {
                            ListViewItem listitem = new ListViewItem(l[0].ToString());
                            listitem.SubItems.Add(l[1].ToString());
                            listitem.SubItems.Add(l[2].ToString());
                            listitem.SubItems.Add(l[3].ToString());
                            listitem.SubItems.Add(l[4].ToString());
                            listitem.SubItems.Add(l[5].ToString());
                            listitem.SubItems.Add(l[6].ToString());
                            listitem.SubItems.Add(l[7].ToString());
                            listitem.SubItems.Add(l[8].ToString());
                            listitem.SubItems.Add(l[9].ToString());
                            listitem.SubItems.Add(l[10].ToString());
                            listitem.SubItems.Add(l[11].ToString());
                            lv_productos.Items.Add(listitem);                            
                        }
                    }
                }
                else
                {
                    foreach (DataRow l in dtProductos.Rows)
                    {
                        foreach (string x in RecolectarString(l[1].ToString()))
                        {
                            if (CompareString(txt_filtro.Text,x))
                            {
                                ListViewItem listitem = new ListViewItem(l[0].ToString());
                                listitem.SubItems.Add(l[1].ToString());
                                listitem.SubItems.Add(l[2].ToString());
                                listitem.SubItems.Add(l[3].ToString());
                                listitem.SubItems.Add(l[4].ToString());
                                listitem.SubItems.Add(l[5].ToString());
                                listitem.SubItems.Add(l[6].ToString());
                                listitem.SubItems.Add(l[7].ToString());
                                listitem.SubItems.Add(l[8].ToString());
                                listitem.SubItems.Add(l[9].ToString());
                                listitem.SubItems.Add(l[10].ToString());
                                listitem.SubItems.Add(l[11].ToString());
                                lv_productos.Items.Add(listitem);
                            }
                        }
                        
                    }
                }
                if (txt_filtro.Text == "")
                {
                    lv_productos.Items.Clear();
                    foreach (DataRow l in dtProductos.Rows)
                    {
                        ListViewItem listitem = new ListViewItem(l[0].ToString());
                        listitem.SubItems.Add(l[1].ToString());
                        listitem.SubItems.Add(l[2].ToString());
                        listitem.SubItems.Add(l[3].ToString());
                        listitem.SubItems.Add(l[4].ToString());
                        listitem.SubItems.Add(l[5].ToString());
                        listitem.SubItems.Add(l[6].ToString());
                        listitem.SubItems.Add(l[7].ToString());
                        listitem.SubItems.Add(l[8].ToString());
                        listitem.SubItems.Add(l[9].ToString());
                        listitem.SubItems.Add(l[10].ToString());
                        listitem.SubItems.Add(l[11].ToString());
                        lv_productos.Items.Add(listitem);                        
                    }
                }                
                
            }
            if (Txt_Cantidad == sender)
            {
                if (Txt_Cantidad.Text != "" && Txt_CantidadParticionable.Text != "")
                {
                    Txt_CantidadTotal.Text = (Convert.ToInt32(Txt_Cantidad.Text) * Convert.ToInt32(Txt_CantidadParticionable.Text)).ToString();
                }               
            }
            if (Txt_CantidadParticionable == sender)
            {
                if (Txt_Cantidad.Text != "" && Txt_CantidadParticionable.Text != "")
                {
                    Txt_CantidadTotal.Text = (Convert.ToInt32(Txt_Cantidad.Text) * Convert.ToInt32(Txt_CantidadParticionable.Text)).ToString();
                }
                else
                {
                    Txt_CantidadParticionable.Text = "1";
                }
            }
        }
        private void NotLetter(object sender, KeyPressEventArgs e)
        {
            if (sender == Txt_CodigoProducto && e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                Txt_Descripcion.Select();
            }
            if (sender == Txt_Descripcion && e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                Txt_DescripcionTicket.Select();
            }
            if (sender == Txt_DescripcionTicket && e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                Txt_Cantidad.Select();
            }
            if (sender == Txt_Cantidad && e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                Txt_PrecioCosto.Select();
            }
            if (sender == Txt_PrecioCosto && e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                Txt_PrecioVenta.Select();
            }
            if (sender == Txt_PrecioVenta && e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                Txt_StockCritico.Select();
            }
            if (sender == Txt_StockCritico)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    Btn_Aceptar.Select();
                }
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (Txt_PorcentajeGanancia == sender && e.KeyChar == (char)Keys.Enter ) 
            {
                double costo = 0, porcentaje = 0, venta = 0;
                if (Txt_PrecioCosto.Text != "")
                {
                    costo = Convert.ToDouble(Txt_PrecioCosto.Text);
                }
                if (Txt_PrecioVenta.Text != "" && Txt_PorcentajeGanancia.Text != "")
                {
                    porcentaje = Convert.ToDouble(Txt_PorcentajeGanancia.Text);
                }
                venta = Math.Round((costo + ((porcentaje * costo) / 100)), 2);
                Txt_PrecioVenta.Text = venta.ToString();
                cb_prove.Select();
             
            }
            if (Txt_PrecioVenta == sender)
            {
                TextBoxComas(sender, e, Txt_PrecioVenta);
                if (e.KeyChar == (char)Keys.Enter)
                {
                    double Venta = Convert.ToDouble(Txt_PrecioVenta.Text);
                    double Costo = Convert.ToDouble(Txt_PrecioCosto.Text);
                    Txt_PorcentajeGanancia.Text = (Math.Round((((Venta - Costo) * 100) / Costo), 2)).ToString();
                }
            }
            if (Txt_PrecioCosto == sender)
            {
                TextBoxComas(sender, e, Txt_PrecioCosto);
            }
        }
        private void CargarProductos()
        {
            ListaProductos = conexion.LLenarComboBox("Select *From Productos", "Id_Producto", "Cod_Producto");
        }
        private void Event_click(object sender, EventArgs e)
        {
            if (btn_Rubro == sender)
            {
                ComboBoxAjuste(10,cb_Rubro.Text);
            }
            if (btn_Proovedor == sender)
            {
                ComboBoxAjuste(9,cb_Proveedor.Text);
            }
            if (btn_Borrar == sender)
            {
                conexion.InsertarDatos("DELETE FROM Productos where Cod_Producto=" + Convert.ToInt64(Txt_CodigoProducto.Text) + "");
                ModificarListView(1);
                LimpiarCampos();
                Btn_Aceptar.Visible = true;
                btn_Borrar.Visible = false;
                btn_Actualizar.Visible = false;
                Txt_CodigoProducto.Enabled = true;
                
                MessageBox.Show("Borrado Con exito!");

            }
            if (Btn_Cancelar == sender)
            {
                LimpiarCampos();
                Btn_Aceptar.Visible = true;
                btn_Borrar.Visible = false;
                btn_Actualizar.Visible = false;
                Txt_CodigoProducto.Enabled = true;
                CargarComboBox();
            }
            if (Btn_Aceptar == sender)
            {
                if (Txt_CodigoProducto.Text != "" && Txt_Descripcion.Text != "" && Txt_DescripcionTicket.Text != "" && Txt_Cantidad.Text != "" && Txt_PrecioCosto.Text != "" && Txt_PrecioVenta.Text != "" && Txt_StockCritico.Text != "")
                {
                    string consulta = "INSERT into Productos (Cod_Producto, Descripcion, Descripcion_Ticket, Cantidad, Cantida_Particionable, Cantidad_Total, Precio_Unitario, Precio_Costo, Porcentaje_Ganancia, Cod_Proveedor, Categoria, Stock_Critico) " +
                    "Values(" + Convert.ToInt64(Txt_CodigoProducto.Text) + ", '" + Txt_Descripcion.Text + "', '" + Txt_DescripcionTicket.Text + "', " + Convert.ToInt32(Txt_Cantidad.Text) + ", " + Convert.ToInt32(Txt_CantidadParticionable.Text) + "," + (Convert.ToInt32(Txt_Cantidad.Text) * Convert.ToInt32(Txt_CantidadParticionable.Text)) + ", '" + Convert.ToDouble(Txt_PrecioVenta.Text) + "', '" + Convert.ToDouble(Txt_PrecioCosto.Text) + "', '" + Convert.ToDouble(Txt_PorcentajeGanancia.Text) + "', '" + cb_prove.SelectedValue + "', '" + Txt_Rubro.Text + "', " + Convert.ToInt32(Txt_StockCritico.Text) + ");";
                    conexion.InsertarDatos(consulta);
                    ModificarListView(3);
                    LimpiarCampos();
                    MessageBox.Show("El artículo fue agregado con éxito.");
                }
                else 
                {
                    MessageBox.Show("Falta Completar Algún Campo.");
                }

            }
            if (btn_Cerrar == sender) 
            { 
                this.Close(); 
            }
            if (btn_Actualizar == sender) 
            {
                if (ListaProductos.ContainsKey(id_tabla.ToString()))
                {
                    conexion.InsertarDatos("UPDATE Productos SET Descripcion ='" + Txt_Descripcion.Text + "', Descripcion_Ticket ='" + Txt_DescripcionTicket.Text + "', Cantidad=" + Convert.ToInt32(Txt_Cantidad.Text) + ", Cantida_Particionable=" + Convert.ToInt32(Txt_CantidadParticionable.Text) + ", Cantidad_Total=" + (Convert.ToInt32(Txt_Cantidad.Text) * Convert.ToInt32(Txt_CantidadParticionable.Text)) + ",Precio_Unitario ='" + Convert.ToDouble(Txt_PrecioVenta) + "', Precio_Costo='" + Convert.ToDouble(Txt_PrecioCosto.Text) + "', Porcentaje_Ganancia='" + Convert.ToDouble(Txt_PorcentajeGanancia.Text) + "', Cod_Proveedor=" + cb_prove.SelectedValue + ", Categoria='" + Txt_Rubro.Text + "', Stock_Critico=" + Convert.ToInt32(Txt_StockCritico.Text) + ", Cod_Producto=" + Convert.ToInt64(Txt_CodigoProducto.Text) + " where id_Producto =" + id_tabla + ";");
                    ModificarListView(2);
                    LimpiarCampos();
                    Btn_Aceptar.Visible = true;
                    btn_Borrar.Visible = false;
                    btn_Actualizar.Visible = false;
                    CargarComboBox();
                    CargarListView();
                }
                else
                {
                    if (Rubros.ContainsKey(Txt_CodigoProducto.Text))
                    {
                        lb_Alerta.Visible = true;
                        btn_Actualizar.Enabled = false;
                        MessageBox.Show("El còdigo ingresado ya existe, por favor modifiquelo.");
                    }
                }
            }
        }
        private void LLenarComboBox(ComboBox cb,string x)
        {
            if (cb == cb_prove) 
            {
                try
                {
                    Proveedores_Lista = conexion.LLenarComboBox("SELECT * FROM Proveedores;", x, "Cod_Proveedor");
                    BindingSource ls = new BindingSource();
                    ls.DataSource = Proveedores_Lista;
                    cb_prove.DataSource = ls;
                    cb_prove.DisplayMember = "value";
                    cb_prove.ValueMember = "key";
                    cb_prove.Text = "Seleccione un Proovedor";
                }
                catch
                {
                    cb_prove.Text = "Seleccione un Proovedor";
                }
            }
            if (cb == cb_Proveedor)
            {
                try
                {
                    Proveedores_Lista = conexion.LLenarComboBox("SELECT * FROM Proveedores;", x, "Cod_Proveedor");
                    BindingSource ls = new BindingSource();
                    ls.DataSource = Proveedores_Lista;
                    cb_Proveedor.DataSource = ls;
                    cb_Proveedor.DisplayMember = "value";
                    cb_Proveedor.ValueMember = "key";
                    cb_Proveedor.Text = "Seleccione un Proveedor";
                }
                catch
                {
                    cb_Proveedor.Text = "Seleccione un Proveedor";
                }
            }
            if (cb == cb_Rubro)
            {
                try
                {
                    Rubros = conexion.LLenarComboBox("SELECT * FROM Productos;", x, "Cod_Producto");
                    BindingSource ls = new BindingSource();
                    ls.DataSource = Rubros;
                    cb_Rubro.DataSource = ls;
                    cb_Rubro.DisplayMember = "value";
                    cb_Rubro.ValueMember = "key";
                    cb_Rubro.Text = "Seleccione un Rubro";
                }
                catch
                {
                    cb_Rubro.Text = "Seleccione un Rubro";
                }
            }

        }
        private void CargarListView() 
        {
            lv_productos.Items.Clear();
            OleDbDataReader DBdatareader = conexion.ConsultaDatos("SELECT * FROM Productos;");
            while (DBdatareader.Read())
            {
                ListViewItem item = new ListViewItem(DBdatareader["Cod_Producto"].ToString());
                item.SubItems.Add(DBdatareader[1].ToString());
                item.SubItems.Add(DBdatareader[2].ToString());
                item.SubItems.Add(DBdatareader[3].ToString());
                item.SubItems.Add(DBdatareader[4].ToString());
                item.SubItems.Add(DBdatareader[5].ToString());
                item.SubItems.Add("$" + DBdatareader[6].ToString());
                item.SubItems.Add("$" + DBdatareader[7].ToString());
                item.SubItems.Add("%" + DBdatareader[8].ToString());
                item.SubItems.Add(Proveedores_Lista[DBdatareader[9].ToString()].ToString());
                item.SubItems.Add(DBdatareader[11].ToString());
                item.SubItems.Add(DBdatareader[13].ToString());
                lv_productos.Items.Add(item);
            }
            dtProductos = new DataTable();
            foreach (ColumnHeader chtext in lv_productos.Columns)
            {
                dtProductos.Columns.Add(chtext.Text);
            }
            foreach (ListViewItem item in lv_productos.Items)
            {
                DataRow row = dtProductos.NewRow();
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    row[i] = item.SubItems[i].Text;
                }
                dtProductos.Rows.Add(row);
            }
        }
        private void LimpiarCampos()
        {
            Txt_Cantidad.Text = "";
            Txt_CantidadParticionable.Text = "1";
            Txt_CantidadTotal.Text = "";
            Txt_CodigoProducto.Text = "";
            Txt_Descripcion.Clear();
            Txt_DescripcionTicket.Clear();
            Txt_PrecioCosto.Text = "";
            Txt_PrecioVenta.Text = "";
            Txt_PorcentajeGanancia.Text = "";
            cb_prove.Text = "";
            Txt_Rubro.Clear();
            Txt_StockCritico.Clear();
            Txt_CodigoProducto.Select();
            LLenarComboBox(cb_prove, "Nombre_RazonSocial");
            LLenarComboBox(cb_Proveedor, "Nombre_RazonSocial");
            LLenarComboBox(cb_Rubro, "Cod_Producto");
        }
        private void LeaveEvent(object sender, EventArgs e)
        {
            if (cb_prove == sender)
            {
                if (!Proveedores_Lista.ContainsValue(cb_prove.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("El proovedor no exite ¿desea agregarlo?", "Alerta", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        frm_NuevoProveedor frmnp = new frm_NuevoProveedor(true);
                        frmnp.ShowDialog();
                        LLenarComboBox(cb_prove, "Nombre_RazonSocial");
                        LLenarComboBox(cb_Proveedor, "Nombre_RazonSocial");
                        cb_prove.Text = frmnp.CampoNombre();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        cb_prove.DroppedDown = true;
                    }
                }
            }
            if (Txt_Cantidad == sender)
            {
                if (Txt_Cantidad.Text != "")
                {
                    Txt_Cantidad.Text = (Convert.ToInt32(Txt_Cantidad.Text)).ToString();
                }
                if (Txt_Cantidad.Text == "") 
                {
                    Txt_Cantidad.Text = "0";
                }
            }
            if (Txt_CodigoProducto == sender) 
            {
                if (!ListaProductos.ContainsKey(id_tabla.ToString()))
                {
                    if (Rubros.ContainsKey(Txt_CodigoProducto.Text))
                    {
                        lb_Alerta.Visible = true;
                        OleDbDataReader dtr = conexion.ConsultaDatos("Select * From Productos where Cod_Producto = "+Convert.ToInt64(Txt_CodigoProducto.Text)+"");
                        ArrayList idProveedores = new ArrayList();
                        while (dtr.Read())
                        {
                            idProveedores.Add(dtr["Cod_Proveedor"].ToString());
                        }
                        string texto = "";
                        foreach (string x in idProveedores)
                        {
                            texto = texto+Proveedores_Lista[x]+",";
                        }
                        DialogResult dr = MessageBox.Show("¿El Codigo ya existe con el proveedor "+texto+" desea cargarlo con un distinto proveedor ?","Alerta", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                foreach (string x in idProveedores)
                                {
                                    Proveedores_Lista.Remove(x);
                                }
                                BindingSource ls = new BindingSource();
                                ls.DataSource = Proveedores_Lista;
                                cb_prove.DataSource = ls;
                                cb_prove.DisplayMember = "value";
                                cb_prove.ValueMember = "key";
                                cb_prove.Text = "Seleccione un Proovedor";
                                break;
                            case DialogResult.No:
                                LimpiarCampos();
                                break;
                        } 
                    }
                    else
                    {
                        lb_Alerta.Visible = false;
                        Btn_Aceptar.Enabled = true;
                    }
                }
            }
            if (Txt_PrecioCosto == sender)
            {
                if (Txt_PrecioCosto.Text != "0" && Txt_PrecioCosto.Text != "")
                {
                    Txt_PrecioVenta.Enabled = true;
                    Txt_PorcentajeGanancia.Enabled = true;
                }
                if (Txt_PrecioCosto.Text == "")
                {
                    Txt_PrecioVenta.Enabled = false;
                    Txt_PorcentajeGanancia.Enabled = false;
                }
            }
            if (Txt_PrecioVenta == sender)
            {
                if (Txt_PrecioCosto.Text != "" &&Txt_PrecioVenta.Text != "")
                {
                    Txt_PorcentajeGanancia.Text = Math.Round(((Convert.ToDouble(Txt_PrecioVenta.Text) / Convert.ToDouble(Txt_PrecioVenta.Text)) - 1) * 100, 2).ToString(); 
                } 
            }
            if (Txt_PorcentajeGanancia == sender)
            {
                if (Txt_PrecioCosto.Text != "" &&Txt_PorcentajeGanancia.Text != "")
                {
                    Txt_PrecioVenta.Text = Math.Round(Convert.ToDouble(Txt_PrecioCosto.Text) + Convert.ToDouble(Txt_PrecioCosto.Text) * Convert.ToDouble(Txt_PorcentajeGanancia.Text) / 100, 2).ToString();
                }
            }
        }
        private void lv_productos_DoubleClick(object sender, EventArgs e)
        {
            
            Btn_Aceptar.Visible = false;
            btn_Borrar.Visible = true;
            btn_Actualizar.Visible = true;
            ListViewItem listItem = lv_productos.SelectedItems[0];
            Txt_CodigoProducto.Text = listItem.Text;
            Txt_Descripcion.Text = listItem.SubItems[1].Text;
            Txt_DescripcionTicket.Text = listItem.SubItems[2].Text;
            Txt_Cantidad.Text = listItem.SubItems[3].Text;
            Txt_PrecioCosto.Text = listItem.SubItems[7].Text.Replace('$', ' ');
            Txt_PrecioVenta.Text = listItem.SubItems[6].Text.Replace('$',' ');
            foreach (DictionaryEntry c in Proveedores_Lista) 
            {
                if (c.Value.ToString() == listItem.SubItems[9].Text) 
                {
                    cb_prove.SelectedValue = c.Key;
                }
            }
            Txt_Rubro.Text = listItem.SubItems[10].Text;
            Txt_StockCritico.Text = listItem.SubItems[11].Text;
            id_tabla = Convert.ToInt64(ListaProductos[Txt_CodigoProducto.Text]);
        }
        private void CargarComboBox()
        {
            LLenarComboBox(cb_prove, "Nombre_RazonSocial");
            LLenarComboBox(cb_Proveedor, "Nombre_RazonSocial");
            LLenarComboBox(cb_Rubro, "Categoria");
            foreach (DictionaryEntry s in Rubros) //ERROR
            {
                Txt_Rubro.AutoCompleteCustomSource.Add(s.Value.ToString());
            }
        }
        private void ModificarListView(int opcion)
        {
            switch (opcion)
            {
                case 1:// BORRA ELEMENTO SELECCIONADO
                    foreach (ListViewItem l in lv_productos.SelectedItems)
                    {
                        lv_productos.Items.RemoveAt(l.Index);
                    }
                    break;
                case 2:// MODIFICAR ELEMENTO
                    foreach (ListViewItem l in lv_productos.SelectedItems)
                    {
                        lv_productos.Items.RemoveAt(l.Index);
                    }
                    ListViewItem item = new ListViewItem(Txt_CodigoProducto.Text);
                    item.SubItems.Add(Txt_Descripcion.Text);
                    item.SubItems.Add(Txt_DescripcionTicket.Text);
                    item.SubItems.Add(Txt_Cantidad.Text);
                    item.SubItems.Add(Txt_CantidadParticionable.Text);
                    item.SubItems.Add(Txt_CantidadTotal.Text);
                    item.SubItems.Add("$" + Txt_PrecioVenta.Text);
                    item.SubItems.Add("$" + Txt_PrecioCosto.Text);
                    item.SubItems.Add("%"+ Txt_PorcentajeGanancia.Text);
                    item.SubItems.Add(cb_prove.Text);
                    item.SubItems.Add(Txt_Rubro.Text);
                    item.SubItems.Add(Txt_StockCritico.Text);
                    lv_productos.Items.Add(item);                    
                    break;
                case 3:// AGREGAR ELEMENTO
                    ListViewItem item2 = new ListViewItem(Txt_CodigoProducto.Text);
                    item2.SubItems.Add(Txt_Descripcion.Text);
                    item2.SubItems.Add(Txt_DescripcionTicket.Text);
                    item2.SubItems.Add(Txt_Cantidad.Text);
                    item2.SubItems.Add(Txt_CantidadParticionable.Text);
                    item2.SubItems.Add(Txt_CantidadTotal.Text);
                    item2.SubItems.Add("$" + Txt_PrecioVenta.Text);
                    item2.SubItems.Add("$" + Txt_PrecioCosto.Text);
                    
                    item2.SubItems.Add("%"+ Txt_PorcentajeGanancia.Text);
                    item2.SubItems.Add(cb_prove.Text);
                    item2.SubItems.Add(Txt_Rubro.Text);
                    item2.SubItems.Add(Txt_StockCritico.Text);
                    lv_productos.Items.Add(item2);
                    break;
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
        private string QuitarCeros(string txt)
        {
            if (txt == "")
            {
                return txt;
            }
            double aux = Convert.ToDouble(txt);
            return aux.ToString();
        }
        private void ComboBoxAjuste(int i, string b)
        {
            lv_productos.Items.Clear();
            DataTable dt = new DataTable();
            int n;
            bool isNumeric = int.TryParse(txt_filtro.Text, out n);
            if (txt_filtro.Text != "") {
                if (isNumeric)
                {
                    foreach (DataRow l in dtProductos.Rows)
                    {
                        if (CompareString(txt_filtro.Text, l[0].ToString()) && b == l[i].ToString())
                        {
                            ListViewItem listitem = new ListViewItem(l[0].ToString());
                            listitem.SubItems.Add(l[1].ToString());
                            listitem.SubItems.Add(l[2].ToString());
                            listitem.SubItems.Add(l[3].ToString());
                            listitem.SubItems.Add(l[4].ToString());
                            listitem.SubItems.Add(l[5].ToString());
                            listitem.SubItems.Add(l[6].ToString());
                            listitem.SubItems.Add(l[7].ToString());
                            listitem.SubItems.Add(l[8].ToString());
                            listitem.SubItems.Add(l[9].ToString());
                            listitem.SubItems.Add(l[10].ToString());
                            listitem.SubItems.Add(l[11].ToString());
                            lv_productos.Items.Add(listitem);
                        }
                    }
                }
                else
                {
                    foreach (DataRow l in dtProductos.Rows)
                    {
                        foreach (string x in RecolectarString(l[1].ToString()))
                        {
                            if (CompareString(txt_filtro.Text, x) && b == l[i].ToString())
                            {
                                ListViewItem listitem = new ListViewItem(l[0].ToString());
                                listitem.SubItems.Add(l[1].ToString());
                                listitem.SubItems.Add(l[2].ToString());
                                listitem.SubItems.Add(l[3].ToString());
                                listitem.SubItems.Add(l[4].ToString());
                                listitem.SubItems.Add(l[5].ToString());
                                listitem.SubItems.Add(l[6].ToString());
                                listitem.SubItems.Add(l[7].ToString());
                                listitem.SubItems.Add(l[8].ToString());
                                listitem.SubItems.Add(l[9].ToString());
                                listitem.SubItems.Add(l[10].ToString());
                                listitem.SubItems.Add(l[11].ToString());
                                lv_productos.Items.Add(listitem);
                            }
                        }

                    }
                }
            }
            else
            {
                foreach (DataRow l in dtProductos.Rows)
                {
                    if (b == l[i].ToString())
                    {
                        ListViewItem listitem = new ListViewItem(l[0].ToString());
                        listitem.SubItems.Add(l[1].ToString());
                        listitem.SubItems.Add(l[2].ToString());
                        listitem.SubItems.Add(l[3].ToString());
                        listitem.SubItems.Add(l[4].ToString());
                        listitem.SubItems.Add(l[5].ToString());
                        listitem.SubItems.Add(l[6].ToString());
                        listitem.SubItems.Add(l[7].ToString());
                        listitem.SubItems.Add(l[8].ToString());
                        listitem.SubItems.Add(l[9].ToString());
                        listitem.SubItems.Add(l[10].ToString());
                        listitem.SubItems.Add(l[11].ToString());
                        lv_productos.Items.Add(listitem);
                    }
                }
            }
        }
        private void TextBoxComas(object sender, KeyPressEventArgs e,TextBox txt)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Oemcomma && (e.KeyChar != (char)Keys.OemPeriod)))
            {
                if(e.KeyChar == '.')
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
    }
}
