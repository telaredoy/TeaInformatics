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
    public partial class frm_NuevoCliente : Form
    {
        private Class1 c = new Class1();
        private Send s = Send.GetSend();
        private Datos datos;
        private MaskedTextBox _txt_cuit;
        private frm_Cliente cliente;
        public frm_NuevoCliente(Datos datos, MaskedTextBox _txt_cuit,frm_Cliente cliente)
        {
            InitializeComponent();
            this.datos = datos;
            this.cliente = cliente;
            this._txt_cuit = _txt_cuit;
            txt_Filtro.Text = _txt_cuit.Text;
        }

        private void KeyEvent(object sender, KeyPressEventArgs e)
        {
            if (txt_Nombre == sender)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = false;
                    txt_Filtro.Select();
                }
            }
            if (txt_Filtro == sender)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        e.Handled = false;
                        txt_Direccion.Select();
                    }
                    return;
                }
            }
            if (txt_Direccion == sender)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = false;
                    txt_Telefono.Select();
                }
            }
            if (txt_Telefono == sender)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        e.Handled = false;
                        txt_Email.Select();
                    }
                }
            }
            if (txt_Email == sender)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = false;
                    txt_Ciudad.Select();
                }
            }
            if (txt_Ciudad == sender)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = false;
                    txt_Nombre_Responsable.Select();
                }
            }
            if (txt_Nombre_Responsable == sender)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = false;
                    txt_Telefono_Responsable.Select();
                }
            }
            if (txt_Telefono_Responsable == sender)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        e.Handled = false;
                        CargarDatos();
                    }
                }
            }
        }

        private void CargarDatos()
        {
            if (txt_Nombre.Text != "" && txt_Filtro.Text != "")
            {
                Mensaje msj = new Mensaje();
                msj.cliente = new Cliente(txt_Nombre.Text, txt_Filtro.Text, txt_Direccion.Text, txt_Telefono.Text, txt_Email.Text, txt_Ciudad.Text, txt_Nombre_Responsable.Text, txt_Telefono_Responsable.Text);
                msj.op = 3;
                datos.setCliente(msj.cliente);
                try
                {
                    s.EnviarMensaje(c.SerializarObj(msj));
                    MessageBox.Show("Cargado con exito!");
                    _txt_cuit.Text = txt_Filtro.Text;
                    cliente.CerrarVentana();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error 101");
                }
            }
            else
            {
                MessageBox.Show("Datos minimos Nombre o Razón Social y Cuit");
            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (btn_Cargar == sender)
            {
                CargarDatos();
                this.Close();
            }
            if (btn_Cancelar == sender)
            {
                this.Close();
            }
        }

    }
}
