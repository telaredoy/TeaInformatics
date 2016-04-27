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
    public partial class DevolucionSinStock : Form
    {
        private Datos datos = Datos.getDatos();
        Class1 class1 = new Class1();
        Send send = Send.GetSend();
        DataTable dt_Auxiliar;
        Hashtable lista_proveedores;
        public DevolucionSinStock()
        {
            InitializeComponent();
            lista_proveedores = new Hashtable();
            dt_Auxiliar = new DataTable();
            dt_Auxiliar.Columns.Add("codigo");
            dt_Auxiliar.Columns.Add("cantidad");
            foreach (DataRow dr in datos.getProveedores().Rows)
            {
                lista_proveedores.Add(dr[0], dr[1]);
            }
            BindingSource ls = new BindingSource();
            ls.DataSource = lista_proveedores;
            cb_Proveedores.DataSource = ls;
            cb_Proveedores.DisplayMember = "value";
            cb_Proveedores.ValueMember = "key";
            cb_Proveedores.Text = "seleccione un proveedor";
            this.cb_Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Cancelar == sender)
            {
                this.Close();
            }
            if (btn_Devolver == sender)
            {

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
    }
}
