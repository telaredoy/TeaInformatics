using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Xml;
using System.Collections;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Serial;

namespace Terminal
{
    public class ConexionSocket
    {
        private Class1 serial = new Class1();
        private Datos datos ;
        private Mensaje msj;
        private ListView lv_Productos;
        private Label label_Total;
        private TcpClient Cliente;
        private NetworkStream StreamCliente;
        private Thread Hilo;
        private string IP;
        private int Port;
        private int IDTerminal;
        public bool Connected; 
        public ConexionSocket(ListView lv, Label lb_Total,Datos datos)
        {
            this.datos = datos;
            this.lv_Productos = lv;
            this.label_Total = lb_Total;
            Conectar();
        }

        private void Conectar()
        {
            Connected = false;
            try
            {
                System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader("c:\\Terminal.xml");
                IDTerminal = 0;
                while (reader.Read())
                {
                    switch (reader.Name)
                    {
                        case "Mensaje":
                            IDTerminal = Convert.ToInt16(reader.ReadString());
                            break;
                        case "IP":
                            IP = reader.ReadString();
                            break;
                        case "PUERTO":
                            Port = Convert.ToInt32(reader.ReadString());
                            break;
                    }
                }
                msj = new Mensaje();
                Cliente = new TcpClient(this.IP, this.Port);
                StreamCliente = Cliente.GetStream();
                msj.NombreTerminal = "Terminal";
                msj.Prioridad = IDTerminal;
                msj.op = 4;
                Send s = Send.GetSend();
                s.StreamCliente = this.StreamCliente;
                s.Cliente = this.Cliente;
                s.EnviarMensaje(serial.SerializarObj(msj));
                Connected = true;
                this.Hilo = new Thread(SubProceso);
                this.Hilo.IsBackground = true;
                this.Hilo.Start();
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Error 100 - Sin conexion al servidor ¿Intentar Reconectar?", "Sin conexion a el servidor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Conectar();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Connected = false;
                    Application.Exit();
                }
            } 
        }
        public void Conectar(string User, string Password)
        {
            try
            {
                Mensaje msn = new Mensaje();
                msn.Password = Password;
                msn.User = User;
                msn.op = 0;
                Byte[] data = serial.SerializarObj(msn);
                StreamCliente.Write(data, 0, data.Length);
                StreamCliente.Flush();
            }
            catch
            {
                MessageBox.Show("Error al conectar con el servidor");
            }
        }
        private void SubProceso()
        {
            int IContador = 0;
            while (Connected)
            {
                if (IContador == 5)
                {
                    MessageBox.Show("Se supero el maximo de espera de conexion");
                    break;
                }
                Byte[] msj_en_Byte = new Byte[20000000];
                try
                {
                    StreamCliente = Cliente.GetStream();
                    StreamCliente.Read(msj_en_Byte, 0, msj_en_Byte.Length);
                }
                catch
                {
                    MessageBox.Show("Conexion perdida");
                    IContador++;
                    continue;
                }
                Datos(serial.LoadMensaje(msj_en_Byte));
            }
            Hilo.Abort();
            Application.Exit();
        }
        private void Datos(Mensaje msg)
        {
            datos.SubMensaje(msg.op, msg);
        }
    }
}
