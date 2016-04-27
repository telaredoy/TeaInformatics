using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
namespace frmPrincipal
{
    public partial class frm_Principal : Form
    {
        private Conexion conexion = Conexion.getintance();
        public frm_Principal()
        {
            InitializeComponent();
            /*
            Form_Login Loguin = new Form_Login();
            Loguin.ShowDialog();
            if (Loguin.LoguinOK1) 
            {
                this.Show();
            }*/
            CargarVendidos();
            CargarStockCritico();
        }

        private void CargarVendidos()
        {
            lt_Rubros.Items.Clear();
            Hashtable hs = new Hashtable();
            /*OleDbDataReader dr = conexion.ConsultaDatos("Select *from Vendidos where Fecha >= #" + dateTimePicker1.Value.Date + "# and Fecha <=#" + dateTimePicker2.Value.Date + "# order by Fecha asc");
            while (dr.Read())
            {
                if (hs.ContainsKey(dr["Cod_Producto"].ToString()))
                {
                    string[] s1 = (string[])hs[dr["Cod_Producto"].ToString()];
                    string Descripcion = s1[0];
                    int cantidad = Convert.ToInt32(s1[1])+ Convert.ToInt32(dr["Cantidad"].ToString());
                    double ganancia = Convert.ToDouble(s1[2])+Convert.ToDouble(dr["Ganancia"].ToString());
                    string[] s2 = new string[3] { Descripcion, cantidad.ToString(), ganancia.ToString() };
                    hs[dr["Cod_Producto"].ToString()] = s2;
                }
                else
                {
                    hs.Add(dr["Cod_Producto"].ToString(),new string[3]{dr["Descripcion"].ToString(),dr["Cantidad"].ToString(),dr["Ganancia"].ToString()});
                }
            }
            foreach(DictionaryEntry dc in hs)
            {
                string[] s1 = (string[])dc.Value;                
                ListViewItem l = new ListViewItem(s1[0]);
                l.SubItems.Add(s1[1]);
                l.SubItems.Add(s1[2]);
                lt_Rubros.Items.Add(l);
            }*/
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (verMovimientosDeCajeroToolStripMenuItem == sender)
            {
                frm_MovimientoCajero mf = new frm_MovimientoCajero();
                mf.ShowDialog();
            }
            if (verRegistrosDeVentasToolStripMenuItem == sender)
            {
                RegistroDeVentas rv = new RegistroDeVentas();
                rv.ShowDialog();
            }
            if (ajustesProductosToolStripMenuItem == sender)
            {
                Frm_AjustesProducto frm = new Frm_AjustesProducto();
                frm.ShowDialog();
            }
            if(pagarAProveedorToolStripMenuItem == sender)
            {
                frm_PagarAProveedor frm = new frm_PagarAProveedor();
                frm.ShowDialog();
            }
            if (cargarCompraToolStripMenuItem == sender) 
            {
                frm_CompraDevolucionAProveedor frm = new frm_CompraDevolucionAProveedor();
                frm.ShowDialog();
            }
            if (consultarProveedoresToolStripMenuItem == sender)
            {
                frm_VeroModificarProveedores frmvmp = new frm_VeroModificarProveedores();
                frmvmp.ShowDialog();
            }
            if (verOModificarCajerosToolStripMenuItem == sender)
            {
                frm_VeroModificarCajero vmc = new frm_VeroModificarCajero();
                vmc.ShowDialog();
            }
            if (AgregarNuevoProductoToolStripMenuItem == sender)
            {
                Agregar_Producto ap = new Agregar_Producto();
                ap.ShowDialog();
            }
            if (agregarNuevoCajeroToolStripMenuItem == sender) 
            {
                frm_NuevoCajero frmNC = new frm_NuevoCajero();
                frmNC.ShowDialog();
            }
            if (ingresarNuevoClienteToolStripMenuItem == sender)
            {
                frm_Nuevocliente frmNC = new frm_Nuevocliente();
                frmNC.ShowDialog();
            }
            if (ingresarNuevoProveedorToolStripMenuItem == sender)
            {
                frm_NuevoProveedor frmNP = new frm_NuevoProveedor();
                frmNP.ShowDialog();
            }
            if(verClientesToolStripMenuItem == sender)
            {
                frm_VeroModificarCliente frmNP = new frm_VeroModificarCliente();
                frmNP.ShowDialog();
            }

        }
        private void TimerON(object sender, EventArgs e)
        {
            CargarStockCritico();
        }

        private void CargarStockCritico()
        {
            OleDbDataReader dr = conexion.ConsultaDatos("Select * from Productos where Stock_Critico >= Cantidad_Total");
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["Descripcion"].ToString());
                l.SubItems.Add(dr["Cantidad_Total"].ToString());
                l.SubItems.Add(conexion.ObtenerProveedor(Convert.ToInt32(dr["Cod_Proveedor"].ToString())));
                lt_StockCritico.Items.Add(l);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarVendidos();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ActualizarCajas();
        }

        private void ActualizarCajas()
        {
            conexion.ConexionesRestablecer();
            OleDbDataReader dr = conexion.ConsultaDatos("Select * from Terminales");
            while(dr.Read())
            {
                switch(dr["IdTerminal"].ToString())
                {
                    case "1":
                        lb_TCA1.Text = dr["Caja_Actual"].ToString();
                        lb_TCI1.Text = dr["Caja_Inicial"].ToString();
                        break;
                    case "2":
                        lb_TCA2.Text = dr["Caja_Actual"].ToString();
                        lb_TCI2.Text = dr["Caja_Inicial"].ToString();
                        break;
                    case "3":
                        lb_TCA3.Text = dr["Caja_Actual"].ToString();
                        lb_TCI3.Text = dr["Caja_Inicial"].ToString();
                        break;
                    case "4":
                        lb_TCA4.Text = dr["Caja_Actual"].ToString();
                        lb_TCI4.Text = dr["Caja_Inicial"].ToString();
                        break;
                }
            }
            listView1.Items.Clear();
            dr = conexion.ConsultaDatos("Select TOP 5 *from Logs ORDER BY Id_Logs DESC");
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["Terminal"].ToString());
                l.SubItems.Add(dr["Descripcion"].ToString());
                l.SubItems.Add(conexion.ObtenerUsuario(Convert.ToInt32(dr["Usuario"].ToString())));
                listView1.Items.Add(l);
            }
        }


      
    }
}
