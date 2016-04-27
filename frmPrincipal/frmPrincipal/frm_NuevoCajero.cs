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
    public partial class frm_NuevoCajero : Form
    {
        private Conexion conexion = Conexion.getintance();
        private bool Mod = false;
        private int idTabla = -1;
        public frm_NuevoCajero()
        {
            InitializeComponent();
        }

        public frm_NuevoCajero(int id)
        {
            InitializeComponent();
            Mod = true;
            idTabla = id;
            btn_Cargar.Text = "Actualizar";
            try
            {
                List<string> aux = new List<string>();
                OleDbDataReader DBdatareader = conexion.ConsultaDatos("SELECT * FROM Cajeros,Usuarios where Cajeros.IdCajero=" + id + " and Usuarios.IdCajero=" + id + ";");
                while (DBdatareader.Read())
                {
                    aux.Add(DBdatareader[1].ToString());
                    aux.Add(DBdatareader[2].ToString());
                    aux.Add(DBdatareader[3].ToString());
                    aux.Add(DBdatareader[4].ToString());
                    aux.Add(DBdatareader[5].ToString());
                    aux.Add(DBdatareader[6].ToString());
                    switch (DBdatareader["Prioridad"].ToString())
                    {

                        case "0":
                            cb_Cajero.Text = "Admin";
                            break;
                        case "2":
                            cb_Cajero.Text = "Deposito";
                            break;
                        case "1":
                            cb_Cajero.Text = "Cajero";
                            break;
                    }
                } 
                txt_Nombre.Text = aux[0];
                txt_Apellido.Text = aux[1];
                dt_FechaNacimiento.Text = aux[2];
                txt_Telefono.Text = aux[3];
                txt_Celular.Text = aux[4];
                txt_Email.Text = aux[5];
            }
            catch
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        private void ClickButton(object sender, EventArgs e)
        {
            if (btn_Salir == sender) 
            {
                this.Close(); //@Author Tibe 18/01/2016 Boton Salir cierra el formulario
            }
            if (btn_Cargar == sender) 
            {
                int prioridad = 0;
                    if(cb_Cajero.Text == "Admin"){
                        prioridad = 0;
                    }
                    if(cb_Cajero.Text == "Cajero"){
                        prioridad = 1;
                    }
                    if(cb_Cajero.Text == "Deposito"){
                        prioridad = 2;
                    }
                if (Mod)
                {
                    conexion.InsertarDatos("UPDATE Cajeros SET Nombre = '" + txt_Nombre.Text + "',Apellido= '" + txt_Apellido.Text + "', Fecha='" + dt_FechaNacimiento.Text + "', Telefono='" + txt_Telefono.Text + "', Celular='" + txt_Celular.Text + "', Email='" + txt_Email.Text + "' where IdCajero=" + idTabla + ";");
                    conexion.InsertarDatos("UPDATE Usuarios set Prioridad = " + prioridad + " where IdCajero = " + idTabla + ";");
                    MessageBox.Show("Datos actualizados correctamente!");
                    this.Close();
                }
                else
                {
                    string[] combo = new string[2];
                    combo[0] = (txt_Nombre.Text[0] + txt_Apellido.Text).ToLower(); // Pasamos el user a minuscula
                    combo[1] = (txt_Apellido.Text + dt_FechaNacimiento.Text[0]).ToLower(); // Pasamos la pass a minuscula                      
                    conexion.InsertarDatos("INSERT into Cajeros ( Nombre, Apellido, Fecha, Telefono, Celular, Email) Values('" + txt_Nombre.Text + "', '" + txt_Apellido.Text + "', '" + dt_FechaNacimiento.Text + "', '" + txt_Telefono.Text + "','" + txt_Celular.Text + "', '" + txt_Email.Text + "');");
                    OleDbDataReader dr = conexion.ConsultaDatos( "SELECT * FROM Cajeros where Nombre='" + txt_Nombre.Text + "' and Apellido='" + txt_Apellido.Text + "';");
                    int idCajero = 0;
                    while (dr.Read())
                    {
                        idCajero = Convert.ToInt32(dr["IdCajero"]);
                    }
                    conexion.InsertarDatos("INSERT into Usuarios ( [User], [Password], Prioridad,IdCajero) Values('" + combo[0] + "', '" + combo[1] + "', " + prioridad + ", "+ idCajero+ ")");
                    MessageBox.Show("User: " + combo[0] + " Password: " + combo[1]);            
                }
            }

        }

        private void KeyPressNotNumber(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) //@Author Tibe 18/01/2016 Para que los campos de textbox solo acepten numeros
            {
                e.Handled = true; //@Author Tibe 18/01/2016 El handle True nega el char ingresado si es no es un numero del 0 - 9
            }
        }

        private void frm_NuevoCajero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
