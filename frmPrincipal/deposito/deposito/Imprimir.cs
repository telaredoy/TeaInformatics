using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.Collections;
using Serial;

namespace deposito
{
    public partial class Imprimir : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        private ArrayList lista;
        
        private Engine engine = Engine.getInstance();
        private FontFamily ff;
        private Font font;
        private const float xMax = 800;
        private Hashtable hs_Productos;
        private const float yMax = 1100;
        private int Contador = 1;
        private int Contadorrubro = 0;
        private bool HashMorePags = true;
        private DataTable dt_Productos;
        private Hashtable hs_Rubro;
        private Hashtable h_Productos;
        public Imprimir()
        {
            InitializeComponent();
            hs_Productos = new Hashtable();
            CargoPrivateFontCollection();
            foreach (DataRow dr in engine.getDatos().getProductos().Rows)
            {
                if (hs_Productos.ContainsKey(dr[0].ToString()))
                {
                    continue;
                }
                else
                {
                    hs_Productos.Add(dr[0].ToString(), dr[1].ToString());
                }
            }
            dt_Productos = new DataTable();
            dt_Productos.Columns.Add("Cod");
            dt_Productos.Columns.Add("Des");
            dt_Productos.Columns.Add("Pre");
            dt_Productos.Columns.Add("Rubro");
            Mensaje msj = new Mensaje();
            msj.op = 23;
            engine.EnviarMensaje(msj);
        }
        private void rubro_CheckedChanged(object sender, EventArgs e)
        {
            if (rubro.Checked)
            {
                codigo.Checked = false;
                txt_Codigo.Enabled = false;
                txt_Copias.Enabled = false;
                cb_Rubros.Enabled = true;
            }
            if (codigo.Checked)
            {
                rubro.Checked = false;
                txt_Codigo.Enabled = true;
                txt_Copias.Enabled = true;
                cb_Rubros.Enabled = false;
            }
        }
        private void codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rubro.Checked)
            {
                codigo.Checked = false;
                txt_Codigo.Enabled = false;
                txt_Copias.Enabled = false;
                cb_Rubros.Enabled = true;
            }
            if (codigo.Checked)
            {
                rubro.Checked = false;
                txt_Codigo.Enabled = true;
                txt_Copias.Enabled = true;
                cb_Rubros.Enabled = false;
            }
        }
        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text != "" && txt_Copias.Text != "" && codigo.Checked == true)
            {
                if (hs_Productos.ContainsKey(txt_Codigo.Text))
                {
                    ImprimirCodigo();                      
                }
                else
                {
                    MessageBox.Show("Codigo no existe");
                }
            }
            if (rubro.Checked)
            {
                ImprimirRubro();
            }
        }
        private void ImprimirCodigo()
        {
            Contador = 1;
            printDialog1.Document = new PrintDocument();
            PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();

            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                while(HashMorePags)
                {
                    HashMorePags = false;
                    printDialog1.Document.PrinterSettings = printDialog1.PrinterSettings;
                    printDialog1.Document.PrintPage += PrintPageCodigo;
                }
                VistaPrevia.Document = printDialog1.Document;
                VistaPrevia.ShowDialog();
                //printDialog1.Document.Print();
                
            }
        }
        private void PrintPageCodigo(object sender, PrintPageEventArgs ev)
        {
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font z =new Font("Arial", 10);
            float x = 20;
            float y = 20;
            while (Contador <= Convert.ToInt32(txt_Copias.Text))
            {
                Contador++;
                ev.Graphics.DrawString(hs_Productos[txt_Codigo.Text].ToString(), z, drawBrush, x, y+77);
                ev.Graphics.DrawString(txt_Codigo.Text, font, drawBrush, x, y);
                x += 160 + txt_Codigo.TextLength*2;
                if (x >= (xMax-txt_Codigo.TextLength*10))
                {
                    y += 110;
                    x = 20;
                }
                if (y >= yMax)
                {
                    ev.HasMorePages = true;
                    HashMorePags = true;
                    break;
                }
            }
            
            
        }
        private void ImprimirRubro()
        {
            string [] x = new string[3];
            lista = new ArrayList();
            foreach (DataRow dr in dt_Productos.Rows)
            {
                if (dr[3].ToString() == cb_Rubros.Text)
                {
                    x[0] = dr[0].ToString();
                    x[1] = dr[1].ToString();
                    x[2] = dr[2].ToString();
                    lista.Add(x);
                }
            }
            Contadorrubro = 0;
            printDialog1.Document = new PrintDocument();
            PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();

            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                while (HashMorePags)
                {
                    HashMorePags = false;
                    printDialog1.Document.PrinterSettings = printDialog1.PrinterSettings;
                    printDialog1.Document.PrintPage += PrintPageRubro;
                }
                VistaPrevia.Document = printDialog1.Document;
                VistaPrevia.ShowDialog();
                //printDialog1.Document.Print();

            }
        }
        private void PrintPageRubro(object sender, PrintPageEventArgs ev)
        {
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font z = new Font("Arial", 10);
            float x = 20;
            float y = 20;
            ev.Graphics.DrawString("***" + cb_Rubros.Text + "***", z, drawBrush, x, y-15);
            ev.Graphics.DrawString("||  Codigo     ||                  Descripcion                 ||     Precio Unitario  ||", z, drawBrush, x, y);    
            while (Contadorrubro < lista.Count) 
            {
                y += 20;
                string [] list =(string[])lista[Contadorrubro];
                Contadorrubro++;
                ev.Graphics.DrawString(list[0].ToString(), z, drawBrush, x+20, y);
                ev.Graphics.DrawString(list[1].ToString(), z, drawBrush, x+150, y);
                ev.Graphics.DrawString(list[2].ToString(), z, drawBrush, x+400, y);
                if (y >= yMax)
                {
                    ev.HasMorePages = true;
                    HashMorePags = true;
                    break;
                }
            }


        }
        public void CargarDatatable(DataTable dt)
        {
            h_Productos = new Hashtable();
            hs_Rubro = new Hashtable();
            foreach (DataRow dr in dt.Rows)
            {
                if (hs_Rubro.ContainsKey(dr[3].ToString()))
                {
                    continue;
                }
                else
                {
                    hs_Rubro.Add(dr[3].ToString(), "");
                }
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (h_Productos.ContainsKey(dr[0].ToString()))
                {
                    continue;
                }
                else
                {
                    h_Productos.Add(dr[0].ToString(), "");
                    DataRow dtr = dt_Productos.NewRow();
                    dtr[0] = dr[0].ToString();
                    dtr[1] = dr[1].ToString();
                    dtr[2] = dr[2].ToString();
                    dtr[3] = dr[3].ToString();
                    dt_Productos.Rows.Add(dtr);
                }
            }
            BindingSource ls = new BindingSource();
            ls.DataSource = this.hs_Rubro;
            cb_Rubros.DataSource = ls;
            cb_Rubros.DisplayMember = "key";
            cb_Rubros.ValueMember = "value";
            
        }
        private void CargoPrivateFontCollection()
        {
            // CREO EL BYTE[] Y TOMO SU LONGITUD
            byte[] fontArray = deposito.Properties.Resources.IDAutomationHC39M_Free_Version;
            int dataLength = deposito.Properties.Resources.IDAutomationHC39M_Free_Version.Length;


            // ASIGNO MEMORIA Y COPIO BYTE[] EN LA DIRECCION
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);


            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            //PASO LA FUENTE A LA PRIVATEFONTCOLLECTION
            pfc.AddMemoryFont(ptrData, dataLength);

            //LIBERO LA MEMORIA "UNSAFE"
            Marshal.FreeCoTaskMem(ptrData);
            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);
        }
        private void CargoEtiqueta(Font font)
        {
            FontStyle fontStyle = FontStyle.Regular;

            this.label1.Font = new Font(ff, 20, fontStyle);

        }

    }
}
