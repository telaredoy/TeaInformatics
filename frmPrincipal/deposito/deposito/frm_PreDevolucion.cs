using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deposito
{
    public partial class frm_PreDevolucion : Form
    {
        private Engine engine = Engine.getInstance();
        public frm_PreDevolucion()
        {
            InitializeComponent();
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_EnStock == sender)
            {
                engine.Devolucion_1 = new frm_DevolucionStock();
                engine.Devolucion_1.ShowDialog();
            }
            if (btn_SinStock == sender)
            {
                
            }
        }
    }
}
