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
    public partial class frm_MovimientoCajero : Form
    {
        private Hashtable hs_Cajeros;
        Conexion conexion = Conexion.getintance();
        public frm_MovimientoCajero()
        {
            InitializeComponent();
            hs_Cajeros = new Hashtable();
            OleDbDataReader dr = conexion.ConsultaDatos("Select *from Usuarios,Cajeros where Usuarios.IdCajero = Cajeros.IdCajero;");
            while (dr.Read())
            {
                if (hs_Cajeros.ContainsKey(dr["Id_User"].ToString()))
                {
                    continue;
                }
                else
                {
                    hs_Cajeros.Add(dr["Id_User"].ToString(), dr["Nombre"].ToString() + "  " + dr["Apellido"].ToString());
            
                }
            }
            BindingSource ls = new BindingSource();
            ls.DataSource = hs_Cajeros;
            cb_Cajeros.DataSource = ls;
            cb_Cajeros.DisplayMember = "value";
            cb_Cajeros.ValueMember = "key";
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbDataReader dr = conexion.ConsultaDatos("Select * From Logs where Usuario = "+cb_Cajeros.SelectedValue+"");
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["Dia"].ToString());
                l.SubItems.Add(dr["Descripcion"].ToString());
                l.SubItems.Add(dr["Caja_Actual"].ToString());
                listView1.Items.Add(l);
            }
        }
    }
}
