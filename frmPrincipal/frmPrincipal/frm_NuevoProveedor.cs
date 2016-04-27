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
    public partial class frm_NuevoProveedor : Form
    {
        private Conexion conexion = Conexion.getintance();
        private string nombreRazonSocial = "";
        private bool n = false;
        private int id = -1;
        private bool Mod = false;
        public frm_NuevoProveedor()
        {
            InitializeComponent();
        }
        public frm_NuevoProveedor(bool n)
        {
            InitializeComponent();
            this.n = n;
        }

        public frm_NuevoProveedor(int id)
        {
            InitializeComponent();
            this.id = id;
            Mod = true;
            btn_cancelar.Visible = false;
            groupBox2.Visible = true;
            try
            {
                List<string> aux = new List<string>();
                OleDbDataReader DBdatareader = conexion.ConsultaDatos("SELECT * FROM Proveedores where Cod_Proveedor=" + id + ";");
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
                }
                txt_nombre.Text = aux[0];
                txt_cuit.Text = aux[1];
                txt_Telefono.Text = aux[3];
                txt_direccion.Text = aux[2];
                txt_Cuenta.Text = aux[7];
                txt_ciudad.Text = aux[6];
                txt_Email.Text = aux[4];
                dateCompra.Text = aux[5];
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
                    e.Handled = true;
                    Carga();//Conexion Cargar proveedor.
                    if (n)
                    {
                        this.Close();
                    }

                }
            }

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
                if (Mod)
                {
                    if (conexion.InsertarDatos("UPDATE Proveedores SET Nombre_RazonSocial = '" + txt_nombre.Text + "', Cuit_Cuil= '" + txt_cuit.Text + "', EstadoCuenta='" + Convert.ToDouble(txt_Cuenta.Text) + "', Numero_Telefono='" + txt_Telefono.Text + "', Correo='" + txt_Email.Text + "', Fecha_Ultima_Compra='" + dateCompra.Text + "' where Cod_Proveedor=" + id + ";"))
                    {
                        MessageBox.Show("Actualizado Correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Error en modificar proveedor");
                    }
                }
                else
                {
                    Carga();//Conexion Cargar proveedor.
                    if (n)
                    {
                        this.Close();
                    }
                }
            }
        }
        public string CampoNombre()
        {
            return nombreRazonSocial;
        }
        private void Limpiar_Campos()
        {
            nombreRazonSocial = txt_nombre.Text;
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
            if(conexion.InsertarDatos("INSERT into Proveedores (Nombre_RazonSocial, Cuit_Cuil, Direccion, Numero_Telefono, Correo, Ciudad, EstadoCuenta, Fecha_Ultima_Compra) Values('" + txt_nombre.Text + "', '" + txt_cuit.Text + "', '" + txt_direccion.Text + "', '" + txt_Telefono.Text + "', '" + txt_Email.Text + "', '" + txt_ciudad.Text + "'," + 0 + ",'" + DateTime.Now.ToLocalTime()  + "')"))
            {
                MessageBox.Show("Proveedor agregado con éxito.");
                Limpiar_Campos();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
