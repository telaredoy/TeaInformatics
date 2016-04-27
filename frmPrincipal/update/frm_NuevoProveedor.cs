using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frm_NuevoProveedor : Form
    {
        public frm_NuevoProveedor()
        {
            InitializeComponent();
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_salir == sender)
            {
                this.Close();
            }
        }
    }
}
