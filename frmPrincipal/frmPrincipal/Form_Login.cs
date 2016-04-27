using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace frmPrincipal
{
    public partial class Form_Login : Form
    {
        private bool LoguinOK = false;
        public bool LoguinOK1
        {
            get { return LoguinOK; }
        }
        private Conexion conexion = Conexion.getintance();
        public Form_Login()
        {
            InitializeComponent();
        }

     
        private void Event_Text_Box(object sender, KeyPressEventArgs e)
        {
            if (txt_User == sender)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    txt_Password.Select();
                    e.Handled = true;
                }
            }
            if (txt_Password == sender)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    e.Handled = true;
                    if (txt_User.Text == "" || txt_Password.Text == "")
                    {
                        MessageBox.Show("Falta completar algún campo.\nCompletelos correctamente.");
                    }
                    else
                    {
                        OleDbDataReader dr = conexion.ConsultaDatos("SELECT * FROM Usuarios where User='" + txt_User.Text + "' and Password='" + txt_Password.Text + "' and Prioridad = 1;");
                        if (dr.HasRows)
                        {
                            LoguinOK = true;
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("No posee permisos para iniciar sesion en esta aplicacion");
                        }
                    }
                    
                }
            }
        }

        private void Event_Click(object sender, EventArgs e)
        {
            if (btn_Entrar == sender)
            {
                if (txt_User.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Falta completar algún campo.\nCompletelos correctaente.");
                }
                else
                {
                    OleDbDataReader dr = conexion.ConsultaDatos("SELECT * FROM Usuarios where User='" + txt_User.Text + "' and Password='" + txt_Password.Text + "' and Prioridad = 1;");
                    if (dr.HasRows)
                    {
                        LoguinOK = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No posee permisos para iniciar sesion en esta aplicacion");
                    }
                }
            }
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!LoguinOK)
            {
                Application.Exit();
            }
        }
    }
}
