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
    public partial class Retiro : Form
    {
        public Retiro(string Monto, string Nota, string Empleado, string Hora)
        {
            InitializeComponent();
            txt_Monto.Text = Monto;
            txt_Nota.Text = Nota;
            lb_Empleado.Text = Empleado;
            lb_Fecha.Text = Hora;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
