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
    public partial class frm_VeroModificarCajero : Form
    {
        private Conexion c = Conexion.getintance();
        private DataTable dtCajeros;
        private int IdSelect = -1;
        public frm_VeroModificarCajero()
        {
            InitializeComponent();
            UpdateTabla();
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            if (lv_Cajeros == sender)
            {
                foreach (ListViewItem i in lv_Cajeros.SelectedItems)
                {
                    IdSelect = Convert.ToInt32(i.Text);
                }
            }
            if (btn_Eliminar == sender)
            {
                if (IdSelect != -1)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar el cajero?","Alerta", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        c.InsertarDatos("DELETE FROM Cajeros where IdCajero=" + IdSelect + "");
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
                    frm_NuevoCajero frmnc = new frm_NuevoCajero(IdSelect);
                    frmnc.ShowDialog();
                    UpdateTabla();
                    txt_Buscar.Text = "";
                }
            }
        }
        private void TextChange(object sender, EventArgs e)
        {
            if (txt_Buscar == sender)
            {
                lv_Cajeros.Items.Clear();
                foreach (DataRow l in dtCajeros.Rows)
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
                        lv_Cajeros.Items.Add(listitem);
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
        private void CargarLista()
        {
            lv_Cajeros.Items.Clear();
            foreach (DataRow l in dtCajeros.Rows)
            {
                ListViewItem listitem = new ListViewItem(l[0].ToString());
                listitem.SubItems.Add(l[1].ToString());
                listitem.SubItems.Add(l[2].ToString());
                listitem.SubItems.Add(l[3].ToString());
                listitem.SubItems.Add(l[4].ToString());
                listitem.SubItems.Add(l[5].ToString());
                listitem.SubItems.Add(l[6].ToString());
                lv_Cajeros.Items.Add(listitem);
            } 
        }
        private void UpdateTabla()
        {
            OleDbDataReader DBdatareader = c.ConsultaDatos("SELECT * FROM Cajeros;");
            while (DBdatareader.Read())
            {
                ListViewItem item = new ListViewItem(DBdatareader[0].ToString());
                item.SubItems.Add(DBdatareader[1].ToString());
                item.SubItems.Add(DBdatareader[2].ToString());
                item.SubItems.Add(DBdatareader[3].ToString());
                item.SubItems.Add(DBdatareader[4].ToString());
                item.SubItems.Add(DBdatareader[5].ToString());
                item.SubItems.Add(DBdatareader[6].ToString());
                lv_Cajeros.Items.Add(item);
            }
            dtCajeros = new DataTable();
            foreach (ColumnHeader chtext in lv_Cajeros.Columns)
            {
                dtCajeros.Columns.Add(chtext.Text);
            }
            foreach (ListViewItem item in lv_Cajeros.Items)
            {
                DataRow row = dtCajeros.NewRow();
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    row[i] = item.SubItems[i].Text;
                }
                dtCajeros.Rows.Add(row);
            }
        }
    }
}
