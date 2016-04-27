using Serial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    public partial class ClienteDeuda : Form
    {
        private double Total;
        private Datos datos;
        private Class1 c = new Class1();
        private frm_Terminal t;
        private Send send = Send.GetSend();
        public ClienteDeuda(frm_Terminal t, Datos datos)
        {
            InitializeComponent();
            this.datos = datos;
            this.t = t;
            lb_Cliente.Text = datos.getCliente().NombreRazonSocial;
            this.cb_Pagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Mensaje msj = new Mensaje();
            msj.op = 14;
            msj.IdCliente = datos.getCliente().Cod_Cliente;
            send.EnviarMensaje(c.SerializarObj(msj));              
        }
        public void CargarTabla(DataTable aux) 
        {
            foreach (DataRow dr in aux.Rows)
            {
                ListViewItem l = new ListViewItem(dr[0].ToString());
                l.SubItems.Add(dr[1].ToString());
                l.SubItems.Add(dr[2].ToString());
                l.SubItems.Add(dr[3].ToString());
                if (dr[2].ToString() != "ENTREGA")
                {
                    Total += Convert.ToDouble(dr[3].ToString());
                }
                else
                {
                    Total = Total - Convert.ToDouble(dr[3].ToString());
                }
                lv_DetalleDeuda.Items.Add(l);
            }
            lb_TotalDeuda.Text = "$ " + Total;
            if (Total == 0)
            {
                MessageBox.Show("El cliente no tiene ninguna deuda");
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClienteDeuda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void lv_DetalleDeuda_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem l in lv_DetalleDeuda.SelectedItems)
            {
                if (l.SubItems[2].Text != "ENTREGA")
                {
                    Mensaje msj = new Mensaje();
                    msj.op = 12;
                    msj.N_Ticket = Convert.ToInt32(l.SubItems[1].Text);
                    send.EnviarMensaje(c.SerializarObj(msj));
                }
            }
        }

        private void btn_Abonar_Click(object sender, EventArgs e)
        {
            if (txt_Abonar.Text != "" && txt_Abonar.Text != "0")
            {
                Mensaje msj = new Mensaje();
                msj.op = 13;
                msj._Mensaje = txt_Nota.Text;
                msj.Monto = Convert.ToDouble(txt_Abonar.Text);
                msj.IdCliente = datos.getCliente().Cod_Cliente;
                if (cb_Pagos.Text == "Efectivo")
                {
                    datos.CajaActual += Convert.ToDouble(txt_Abonar.Text);
                    msj.Correcto = true;
                }
                else
                {
                    msj.Correcto = false;
                }
                msj.CajaActual = datos.CajaActual;
                send.EnviarMensaje(c.SerializarObj(msj));
                MessageBox.Show("Abonado con exito, saldo adeudado : " + (Total - Convert.ToDouble(txt_Abonar.Text)) + "");
                //ImprimirTicket();
                this.Close();
            }
            else
            {
                MessageBox.Show("Valor a abonar no valido");
            }
        }

        private void ImprimirTicket()
        {
            CrearTicket ticket = new CrearTicket();
            //Datos de la cabecera del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Cliente : " + datos.getCliente().NombreRazonSocial);
            ticket.TextoIzquierda("");
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         PAGO$", Convert.ToDecimal(txt_Abonar.Text));
            ticket.AgregarTotales("         RESTO$", Convert.ToDecimal(Total - Convert.ToDouble(txt_Abonar.Text)));

        

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        
        }

        private void txt_Abonar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
