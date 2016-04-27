using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Serial;

namespace Terminal
{
    public partial class frm_Cliente : Form
    {
        private Datos datos;
        private frm_Terminal t;
        public frm_Cliente(Datos datos , frm_Terminal t)
        {
            InitializeComponent();
            this.datos = datos;
            this.t = t;
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txt_Filtro.TextLength == 13)
                {
                    foreach (DataRow x in datos.dt_Clientes.Rows)
                    {
                        if (x[2].ToString() == txt_Filtro.Text)
                        {
                            datos.setCliente(new Cliente(Convert.ToInt32(x[0]), x[1].ToString(), x[2].ToString(), x[4].ToString(), x[5].ToString(), x[6].ToString(), x[7].ToString(), x[8].ToString(), x[9].ToString()));
                            t.CentrarFoco();
                            this.Close();
                            return;
                        }
                    }
                    DialogResult dialogResult = MessageBox.Show("El Cliente no exite ¿desea agregarlo?", "Alerta", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        frm_NuevoCliente frm = new frm_NuevoCliente(datos, txt_Filtro, this);
                        frm.ShowDialog();
                        t.CentrarFoco();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Cuit-Cuil incompleto");
                }
            }

        }

        private void ClickEvent(object sender, EventArgs e)
        {
            
                if (btn_Cargar == sender)
                {
                    if (txt_Filtro.TextLength == 13)
                    {
                        foreach (DataRow x in datos.dt_Clientes.Rows)
                        {
                            if (x[2].ToString() == txt_Filtro.Text)
                            {
                                datos.setCliente(new Cliente(Convert.ToInt32(x[0]), x[1].ToString(), x[2].ToString(), x[4].ToString(), x[5].ToString(), x[6].ToString(), x[7].ToString(), x[8].ToString(), x[9].ToString()));
                                this.Close();
                                return;
                            }
                        }
                        DialogResult dialogResult = MessageBox.Show("El Cliente no exite ¿desea agregarlo?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            frm_NuevoCliente frm = new frm_NuevoCliente(datos, txt_Filtro, this);
                            frm.ShowDialog();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }

                        else
                        {
                            MessageBox.Show("Cuit-Cuil incompleto");
                        }
                    }
                }
                if (btn_NuevoCliente == sender)
                {
                    frm_NuevoCliente frm = new frm_NuevoCliente(datos, txt_Filtro, this);
                    frm.ShowDialog();
                }
                if (btn_Cerrar == sender)
                {
                    t.CentrarFoco();
                    this.Close();
                }
            
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                t.CentrarFoco();
                this.Close();
            }
        }

        internal void CerrarVentana()
        {
            t.CentrarFoco();
            this.Close();
        }
    }
}
