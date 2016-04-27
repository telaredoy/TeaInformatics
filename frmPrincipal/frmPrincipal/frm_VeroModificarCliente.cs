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
    public partial class frm_VeroModificarCliente : Form
    {
        private Conexion c = Conexion.getintance();
        private DataTable dtClientes;
        private int IdSelect = -1;
        public frm_VeroModificarCliente()
        {
            InitializeComponent();
            UpdateTabla();
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            if (lv_Clientes == sender)
            {
                foreach (ListViewItem i in lv_Clientes.SelectedItems)
                {
                    IdSelect = Convert.ToInt32(i.Text);
                }
            }
            if (btn_Eliminar == sender)
            {
                if (IdSelect != -1)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar el cajero?", "Alerta", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        c.InsertarDatos("DELETE FROM Cliente where Cod_Cliente=" + IdSelect + "");
                        UpdateTabla();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        IdSelect = -1;
                        CargarLista();
                    }
                }
            }
            if (btn_Salir == sender)
            {
                this.Close();
            }
            if (btn_Modificar == sender)
            {
                if (IdSelect != -1)
                {
                    frm_Nuevocliente frmnc = new frm_Nuevocliente(IdSelect);
                    frmnc.ShowDialog();
                    UpdateTabla();
                    txt_Buscar.Text = "";
                }
            }
        }
        private void CargarLista()
        {
            lv_Clientes.Items.Clear();
            foreach (DataRow l in dtClientes.Rows)
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
                lv_Clientes.Items.Add(listitem);
            }
        }
        private void UpdateTabla()
        {
            lv_Clientes.Items.Clear();
            OleDbDataReader DBdatareader = c.ConsultaDatos("SELECT * FROM Cliente;");
            while (DBdatareader.Read())
            {
                ListViewItem item = new ListViewItem(DBdatareader[0].ToString());
                item.SubItems.Add(DBdatareader[1].ToString());
                item.SubItems.Add(DBdatareader[2].ToString());
                item.SubItems.Add(DBdatareader[3].ToString());
                item.SubItems.Add(DBdatareader[5].ToString());
                item.SubItems.Add(DBdatareader[4].ToString());
                item.SubItems.Add(DBdatareader[6].ToString());
                item.SubItems.Add(DBdatareader[7].ToString());
                item.SubItems.Add(DBdatareader[8].ToString());
                item.SubItems.Add(DBdatareader[9].ToString());
                lv_Clientes.Items.Add(item);
            }
            dtClientes = new DataTable();
            foreach (ColumnHeader chtext in lv_Clientes.Columns)
            {
                dtClientes.Columns.Add(chtext.Text);
            }
            foreach (ListViewItem item in lv_Clientes.Items)
            {
                DataRow row = dtClientes.NewRow();
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    row[i] = item.SubItems[i].Text;
                }
                dtClientes.Rows.Add(row);
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
        private void TextChange(object sender, EventArgs e)
        {
            if (txt_Buscar == sender)
            {
                lv_Clientes.Items.Clear();
                foreach (DataRow l in dtClientes.Rows)
                {
                    if (CompareString(txt_Buscar.Text, l[2].ToString()))
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
                        lv_Clientes.Items.Add(listitem);
                    }
                }
                int n;
                bool isNumeric = int.TryParse(txt_Buscar.Text, out n);
                if (isNumeric)
                {
                    foreach (DataRow l in dtClientes.Rows)
                    {
                        if (CompareString(txt_Buscar.Text, l[2].ToString()))
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
                            lv_Clientes.Items.Add(listitem);
                        }
                    }
                }
                else
                {
                    foreach (DataRow l in dtClientes.Rows)
                    {
                        foreach (string x in RecolectarString(l[1].ToString()))
                        {
                            if (CompareString(txt_Buscar.Text, x))
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
                                lv_Clientes.Items.Add(listitem);
                            }
                        }

                    }
                }
                if (txt_Buscar.Text == "")
                {
                    lv_Clientes.Items.Clear();
                    foreach (DataRow l in dtClientes.Rows)
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
                        lv_Clientes.Items.Add(listitem);
                    }
                }
            }
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
    }
}
