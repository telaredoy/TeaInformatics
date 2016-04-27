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
    public partial class frm_Nuevocliente : Form
    {
        private Conexion conexion = Conexion.getintance();
        private int Id = -1;
        private bool Mod = false;
        public frm_Nuevocliente()
        {
            InitializeComponent();
        }
        public frm_Nuevocliente(int id)
        {
            InitializeComponent();
            Mod = true;
            Id = id;
            btn_cancelar.Visible = false;
            groupBox2.Visible = true;
            try
            {
                List<string> aux = new List<string>();            
                OleDbDataReader DBdatareader = conexion.ConsultaDatos("SELECT * FROM Cliente where Cod_Cliente=" + id + ";");
                while (DBdatareader.Read())
                {
                    aux.Add(DBdatareader[1].ToString());
                    aux.Add(DBdatareader[2].ToString());
                    aux.Add(DBdatareader[3].ToString());
                    aux.Add(DBdatareader[4].ToString());
                    aux.Add(DBdatareader[5].ToString());
                    aux.Add(DBdatareader[6].ToString());
                    aux.Add(DBdatareader[7].ToString());
                    aux.Add(DBdatareader[8].ToString());
                    aux.Add(DBdatareader[9].ToString());
                }
                txt_nombre.Text = aux[0];
                txt_cuit.Text = aux[1];
                txt_telefono.Text = aux[4];
                txt_direccion.Text = aux[3];
                txt_Cuenta.Text = aux[2];
                txt_ciudad.Text = aux[6];
                txt_email.Text = aux[5];
                txt_NombreResponsable.Text = aux[7];
                txt_TelefonoResponsable.Text = aux[8];
            }
            catch
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        private void keypress(object sender, KeyPressEventArgs e)
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
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) //@Author Tibe 18/01/2016 Para que los campos de textbox solo acepten numeros
                {
                    e.Handled = true; //@Author Tibe 18/01/2016 El handle True nega el char ingresado si es no es un numero del 0 - 9
                }
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_telefono.Select();
                }
            }
            if (txt_telefono == sender) 
            {
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
                if(e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_email.Select();
                }
            }
            if (txt_email == sender) 
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_NombreResponsable.Select();
                }
            }
            if (txt_NombreResponsable == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    txt_TelefonoResponsable.Select();
                }
            }
            if (txt_TelefonoResponsable == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    e.Handled = true;
                    Carga();                       
                }
            }
        }

        private void clickevent(object sender, EventArgs e)
        {
           
            if (btn_salir == sender) 
            {
                this.Close(); //@Author Tibe 18/01/2016 Boton Salir cierra el formulario
            }
            if (btn_guardar == sender)
            {
                if (Mod)
                {
                    conexion.InsertarDatos("UPDATE Cliente SET Nombre_RazonSocial = '" + txt_nombre.Text + "',Cuit_Cuil= '" + txt_cuit.Text + "', Estado_Cuenta='" + Convert.ToDouble(txt_Cuenta.Text) + "', Numero_Telefono='" + txt_telefono.Text + "', Email='" + txt_email.Text + "', Nombre_Responsable='" + txt_NombreResponsable.Text + "', Telefono_Responsable='" + txt_TelefonoResponsable.Text + "' where Cod_Cliente=" + Id + ";");
                    MessageBox.Show("Actualizados Correctamente!");
                    this.Close();
                }
                else
                {
                    Carga();//Conexion Cargar Cliente
                }
            }
            if (btn_cancelar == sender) 
            {
                Limpiar_Campos();
            }


        }
        private void Limpiar_Campos()
        {
            txt_ciudad.Clear();
            txt_telefono.Clear();
            txt_cuit.Clear();
            txt_direccion.Clear();
            txt_nombre.Clear();
            txt_NombreResponsable.Clear();
            txt_email.Clear();
            txt_TelefonoResponsable.Clear();
            txt_nombre.Select();

        }
        private void Carga()
        {
            if (conexion.InsertarDatos("INSERT into Cliente (Nombre_RazonSocial, Cuit_Cuil, Estado_Cuenta, Direccion, Numero_Telefono, Email, Ciudad, Nombre_Responsable, Telefono_Responsable) Values('" + txt_nombre.Text + "', '" + txt_cuit.Text + "','0', '" + txt_direccion.Text + "', '" + txt_telefono.Text + "', '" + txt_email.Text + "', '" + txt_ciudad.Text + "', '" + txt_NombreResponsable.Text + "', '" + txt_TelefonoResponsable.Text + "' );"))
            {
                MessageBox.Show("Cliente agregado con éxito.");
                Limpiar_Campos();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }

}
