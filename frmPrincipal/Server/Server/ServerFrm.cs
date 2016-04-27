using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Server
{
    public partial class ServerFrm : Form
    {
        private ConexionSocket cs;
        private Datos datos = Datos.getDatos();
        public ServerFrm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Iniciar == sender)
            {
                try
                {
                    cs = new ConexionSocket();
                    MessageBox.Show("Servidor iniciado correctamente");
                    label1.Visible = true;
                    btn_Iniciar.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Error al iniciar Servidor");

                }
            }
            if (btn_Ocultar == sender)
            {
                this.Visible = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            //Ocultamos el icono de la bandeja de sistema
            notifyIcon1.Visible = false;
        }

        private void ServerFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            datos.Online = false;
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
