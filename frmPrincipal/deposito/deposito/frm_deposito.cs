using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Serial;

namespace deposito
{
    public partial class frm_deposito : Form
    {
        private Engine engine;
        public frm_deposito()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            engine = Engine.getInstance();
            engine.getDatos().autentificado = false;
            engine.Login1 = new frm_Login();
            engine.Deposito1 = this;
            while (!engine.getDatos().autentificado)
            {
                engine.Login1.ShowDialog();
                Thread.Sleep(1000);
            }
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_CerraTerminal == sender)
            {
                this.Close();
            }
            if (btn_ABProductos == sender) 
            {
                engine.Ab_Productos1 = new frm_ABProductos();
                engine.Ab_Productos1.ShowDialog();
            }
            if (btn_CargarStock == sender)
            {
                engine.CargaStock1 = new frm_CargarStock();
                engine.CargaStock1.ShowDialog();
            }
            if (btn_CerrarSesion == sender)
            {
                engine.getDatos().autentificado=false;
                while (engine.getDatos().autentificado == false)
                {
                    engine.Login1.ShowDialog();                    
                }
            }
            if (btn_Devolucion == sender)
            {
                engine.PreDevolucion1 = new frm_PreDevolucion();
                engine.PreDevolucion1.ShowDialog();
            }
            if (btn_Imprimir == sender)
            {
                engine.Imprimir = new Imprimir();
                engine.Imprimir.ShowDialog();
            }
            if (btn_Actualizar == sender)
            {
                Mensaje message = new Mensaje();
                message.op = 16;
                engine.EnviarMensaje(message);
            }
        }

        private void frm_deposito_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mensaje msj = new Mensaje();
            msj.op = 24;
            engine.EnviarMensaje(msj);
        }
    }
}
