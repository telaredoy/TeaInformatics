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
    public partial class Loguin : Form
    {
        private ConexionSocket cs ;
        public Loguin()
        {
            InitializeComponent();
        }
        public void Cargar(ConexionSocket cs)
        {
            this.cs = cs;
        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (txt_User == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_Password.Select();
                }
            }
            if (txt_Password == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    if (txt_User.Text != "" && txt_Password.Text != "")
                    {
                        Conectar();
                        txt_User.Select();
                    }
                    else
                    {
                        MessageBox.Show("Falta completar algun campo");
                    }
                }
            }
        }

        private void Conectar()
        {
            cs.Conectar(txt_User.Text, txt_Password.Text);
            txt_Password.Text = "";
            txt_User.Text = "";
            this.Close();
        }
        public void ErrorConectar() 
        {
            txt_Password.Text = "";
            txt_User.Text = "";
            MessageBox.Show("Datos invalidos");
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (txt_User.Text != "" && txt_Password.Text != "")
            {
                Conectar();
            }
            else
            {
                MessageBox.Show("Falta completar algun campo");
            }
        }
        public void setCaja(string caja)
        {
            lb_CajaInicial.Text = "$ "+caja;
        }
    }
}
