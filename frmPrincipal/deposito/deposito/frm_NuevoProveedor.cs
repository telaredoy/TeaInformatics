using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Serial;

namespace deposito
{
    public partial class frm_NuevoProveedor : Form
    {
        private Engine engine = Engine.getInstance();
        private Hashtable hs_Proveedores;
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
            if (btn_cancelar == sender)
            {
                Limpiar_Campos();
            }
            if (btn_guardar == sender)
            {

                if (txt_ciudad.Text != "" && txt_cuit.Text != "" && txt_direccion.Text != "" && txt_Email.Text != "" && txt_nombre.Text != "" && txt_Telefono.Text != "")
                {
                    Carga();//Conexion Cargar proveedor.
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }

            }
        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (txt_nombre == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_cuit.Select();
                }
            }
            if (txt_cuit == sender)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_Telefono.Select();
                }
            }
            if (txt_Telefono == sender)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_direccion.Select();
                }
            }
            if (txt_direccion == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_ciudad.Select();
                }
            }
            if (txt_ciudad == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_Email.Select();
                }
            }
            if (txt_Email == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    if (txt_ciudad.Text != "" && txt_cuit.Text != "" && txt_direccion.Text != "" && txt_Email.Text != "" && txt_nombre.Text != "" && txt_Telefono.Text != "")
                    {
                        e.Handled = true;
                        Carga();//Conexion Cargar proveedor.
                    }
                    else
                    {
                        MessageBox.Show("Complete todos los campos");
                    }

                }
            }

        }
        private void Limpiar_Campos()
        {
            txt_nombre.Clear();
            txt_ciudad.Clear();
            txt_cuit.Clear();
            txt_direccion.Clear();
            txt_Email.Clear();
            txt_nombre.Clear();
            txt_Telefono.Clear();
            txt_nombre.Select();
        }
        private void Carga()
        {
            Mensaje msj = new Mensaje();
            msj.op = 22;
            msj.proveedor = new Proveedor();
            msj.proveedor.Nombre = txt_nombre.Text;
            msj.proveedor.Telefono = txt_Telefono.Text;
            msj.proveedor.Email = txt_Email.Text;
            msj.proveedor.Direccion = txt_direccion.Text;
            msj.proveedor.Cuit = txt_cuit.Text;
            msj.proveedor.Ciudad = txt_ciudad.Text;
            engine.EnviarMensaje(msj);
            MessageBox.Show("Proveedor Cargado");
            this.Close();
        }

    }
}
