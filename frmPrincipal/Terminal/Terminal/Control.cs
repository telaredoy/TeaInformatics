using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    public partial class Control : Form
    {
        private Datos datos;
        private frm_Terminal t;
        public Control(Datos datos ,frm_Terminal t)
        {
            InitializeComponent();
            this.datos = datos;
            this.t = t;
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Close == sender)
                this.Close();
            if (btn_ControlCaja == sender)
                MessageBox.Show("Caja actual :"+datos.CajaActual);
            if (btn_Cerrar == sender)
                t.CerrarTerminal();
            if (btn_CerrarSesion == sender)
            {
                t.CerrarSesion_();
                this.Close();
            }

        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
