using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Serial;
using System.Threading;

namespace Terminal
{
    public partial class frm_Ventas : Form
    {
        private Send send = Send.GetSend();
        private Class1 c = new Class1();
        private Ventas ventas = Ventas.getInstance();
        private frm_Terminal t;
        public frm_Ventas(frm_Terminal t)
        {
            InitializeComponent();
            this.t = t;
        }
        private void frm_Ventas_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in ventas.dt_Ventas.Rows)
            {
                ListViewItem l = new ListViewItem(dr[0].ToString());
                l.SubItems.Add(dr[2].ToString());
                l.SubItems.Add(dr[3].ToString());
                l.SubItems.Add(dr[4].ToString());
                l.SubItems.Add(dr[1].ToString());
                lv_Ventas.Items.Add(l);
            }
        }
        private void DobleClickEvent(object sender, EventArgs e)
        {
            foreach (ListViewItem l in lv_Ventas.SelectedItems)
            {
                if (l.SubItems[4].Text == "Retiro")
                {
                    Mensaje msj = new Mensaje();
                    msj.op = 6;
                    msj.N_Ticket = Convert.ToInt32(l.SubItems[1].Text);
                    send.EnviarMensaje(c.SerializarObj(msj));
                }
                else
                {
                    Mensaje msj = new Mensaje();
                    msj.op = 7;
                    msj.N_Ticket = Convert.ToInt32(l.SubItems[1].Text);
                    send.EnviarMensaje(c.SerializarObj(msj));
                }
                Thread.Sleep(500);
            }
        }
        public void MostrarTicketRetiro(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                Retiro frm = new Retiro(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                frm.ShowDialog();
                ClearList();
            }

        }
        public void MostrarTicketVenta(Mensaje msj,Datos datos)
        {
            Venta venta = new Venta(msj.N_Ticket, msj.dt_Venta, msj.Porcentaje,datos, msj.Correcto,this);
            venta.ShowDialog();
            ClearList();
        }
        private void ClearList()
        {
            foreach (DataRow dr in ventas.dt_Ventas.Rows)
            {
                lv_Ventas.Items.Clear();
                ListViewItem l = new ListViewItem(dr[0].ToString());
                l.SubItems.Add(dr[2].ToString());
                l.SubItems.Add(dr[3].ToString());
                l.SubItems.Add(dr[4].ToString());
                l.SubItems.Add(dr[1].ToString());
                lv_Ventas.Items.Add(l);
            }
        }
        private void frm_Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                t.CentrarFoco();
            }
        }
        private void EventTextChange(object sender, EventArgs e)
        {
            lv_Ventas.Items.Clear();
            foreach (DataRow dr in ventas.dt_Ventas.Rows)
            {
                if (CompareString(txt_NueroTicket.Text, dr[2].ToString()))
                {
                    ListViewItem l = new ListViewItem(dr[0].ToString());
                    l.SubItems.Add(dr[2].ToString());
                    l.SubItems.Add(dr[3].ToString());
                    l.SubItems.Add(dr[4].ToString());
                    l.SubItems.Add(dr[1].ToString());
                    lv_Ventas.Items.Add(l);
                }
            }
        }
        private bool CompareString(string a, string b)
        {
            int contador_I = 0;
            foreach (char c in a)
            {
                try
                {
                    if (!(Char.ToLower(c) == Char.ToLower(b[contador_I])))
                    {
                        return false;
                    }
                    contador_I++;
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        private List<string> RecolectarString(string txt)
        {
            List<string> v = new List<string> { };
            string aux = "";
            foreach (char x in txt)
            {
                if (x == ' ')
                {
                    v.Add(aux);
                    aux = "";
                    continue;
                }
                aux += x;
            }
            v.Add(aux);
            return v;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            t.CentrarFoco();
            this.Close();
        }

        private void txt_NueroTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_NueroTicket == sender)
            {
                if (e.KeyChar == (Char)Keys.Down || e.KeyChar == (Char)Keys.Enter)
                {
                    if (lv_Ventas.Items.Count > 0)
                    {
                        lv_Ventas.Items[0].Selected = true;
                        lv_Ventas.Select();
                    }
                }
            }

            if (lv_Ventas == sender)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    foreach (ListViewItem l in lv_Ventas.SelectedItems)
                    {
                        if (l.SubItems[4].Text == "Retiro")
                        {
                            Mensaje msj = new Mensaje();
                            msj.op = 6;
                            msj.N_Ticket = Convert.ToInt32(l.SubItems[1].Text);
                            send.EnviarMensaje(c.SerializarObj(msj));
                        }
                        else
                        {
                            Mensaje msj = new Mensaje();
                            msj.op = 7;
                            msj.N_Ticket = Convert.ToInt32(l.SubItems[1].Text);
                            send.EnviarMensaje(c.SerializarObj(msj));
                        }
                    }
                    Thread.Sleep(500);

                }
            
            }
        }
    }
}
