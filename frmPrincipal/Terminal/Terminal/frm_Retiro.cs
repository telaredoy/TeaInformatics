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
    public partial class frm_Retiro : Form
    {
        Class1 c = new Class1();
        Send send = Send.GetSend();
        private Datos datos;
        private frm_Terminal t;
        public frm_Retiro(Datos datos,frm_Terminal t)
        {
            InitializeComponent();
            this.datos = datos;
            this.t = t;
        }

        private void EventKeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Monto == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_Nota.Select();
                }
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
            if (txt_Nota == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    CargarRetiro();
                }
            }

        }

        private void CargarRetiro()
        {
            if (txt_Monto.Text != "" && txt_Nota.Text != "")
            {
                if (Convert.ToDouble(txt_Monto.Text) > 0)
                {
                    if (datos.CajaActual > Convert.ToDouble(txt_Monto.Text))
                    {
                        Mensaje msj = new Mensaje();
                        msj.op = 5;
                        msj.Monto = Convert.ToDouble(txt_Monto.Text);
                        msj._Mensaje = txt_Nota.Text;
                        msj.Empleado = datos.FirmaEmpleado;
                        datos.CajaActual = datos.CajaActual - Convert.ToDouble(txt_Monto.Text);
                        msj.CajaActual = datos.CajaActual;
                        msj.Hora = DateTime.Now.ToLocalTime().ToString();
                        msj.IdRetiro = datos.IdRetiro;
                        send.EnviarMensaje(c.SerializarObj(msj));
                        Ventas ventas = Ventas.getInstance();
                        ventas.CargarRetiro(datos.IdRetiro,msj.Monto, datos.FirmaEmpleado, DateTime.Now.ToLocalTime().ToString());
                        MessageBox.Show("Listo dinero en Caja actual : $ "+datos.CajaActual);
                        t.CentrarFoco();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se puede retirar mas de la caja total");
                    }
                }
                else
                {
                    MessageBox.Show("El valor a retirar no puede ser negativo");
                }
            }
            else
            {
                MessageBox.Show("Campos sin llenar!");
            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Cancelar == sender)
            {
                t.CentrarFoco();
                this.Close();
            }
            if (btn_Retirar == sender)
            {
                CargarRetiro();
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
    }
}
