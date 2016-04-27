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
    public partial class frm_Nuevocliente : Form
    {
        private Conexion conexion = Conexion.getintance(); 
        public frm_Nuevocliente()
        {
            InitializeComponent();
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            if (txtcorreo == sender) 
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    if (conexion.CargarCliente(txtnombre.Text, txtcuit.Text, 0, txtdireccion.Text, txttelefono.Text, txtcorreo.Text))
                    {
                        MessageBox.Show("LISTO");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");

                    }
                    this.Close();
                }
            }
            if (txtcuit == sender) 
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) //@Author Tibe 18/01/2016 Para que los campos de textbox solo acepten numeros
                {
                    e.Handled = true; //@Author Tibe 18/01/2016 El handle True nega el char ingresado si es no es un numero del 0 - 9
                }
                if (e.KeyChar == (Char)Keys.Enter) 
                {
                    e.Handled = true;
                    txttelefono.Select();
                }
            }
            if (txtdireccion == sender) 
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txtcorreo.Select();
                }
            }
            if (txtnombre == sender) 
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txtcuit.Select();
                }
            }
            if (txttelefono == sender) 
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) //@Author Tibe 18/01/2016 Para que los campos de textbox solo acepten numeros
                {
                    e.Handled = true; //@Author Tibe 18/01/2016 El handle True nega el char ingresado si es no es un numero del 0 - 9
                }
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txtdireccion.Select();
                }
            }
        }

        private void clickevent(object sender, EventArgs e)
        {
           
            if (btnsalir == sender) 
            {
                this.Close(); //@Author Tibe 18/01/2016 Boton Salir cierra el formulario
            }
            if (btnguardar == sender) 
            {
                //Conexion Cargar Cliente
                if (conexion.CargarCliente(txtnombre.Text, txtcuit.Text, 0, txtdireccion.Text, txttelefono.Text, txtcorreo.Text))
                {
                    MessageBox.Show("LISTO");
                }
                else 
                {
                    MessageBox.Show("ERROR");
                
                }
                this.Close();
                            
            }
            if (btncancelar == sender) 
            {
                txtcorreo.Clear();
                txtcuit.Clear();
                txtdireccion.Clear();
                txtnombre.Clear();
                txttelefono.Clear();
            }


        }
    }
}
