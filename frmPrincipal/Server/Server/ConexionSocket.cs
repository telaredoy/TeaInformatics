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
using Server;
using Serial;

namespace Server
{
    class ConexionSocket
    {
        private Class1 serial = new Class1();
        private TcpClient Cliente;
        private TcpListener Server;
        private Thread Hilo;
        private Datos datos = Datos.getDatos();
        private Conexion conexion = Conexion.getintance();
        public Hashtable hs;
        public ConexionSocket()
        {
            IniciarServidor();
        }

        private void IniciarServidor()
        {
            int Port = 0;
            string IP = "";
            try
            {
                System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader("c:\\Servidor.xml");
                while (reader.Read())
                {
                    switch (reader.Name)
                    {
                        case "IP":
                            IP = reader.ReadString();
                            break;
                        case "PUERTO":
                            Port = Convert.ToInt32(reader.ReadString());
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar configuracion de conexion");
            }
            try
            {
                IPEndPoint ipend = new IPEndPoint(IPAddress.Parse(IP), Port);
                Server = new TcpListener(ipend);
                Server.Start();
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Error al iniciar servidor ¿Intentar denuevo?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    IniciarServidor();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            hs = new Hashtable();
            datos.setTerminales(hs);
            this.Hilo = new Thread(ServerStart);
            this.Hilo.IsBackground = true;
            this.Hilo.Start();
            datos.Online = true;
        }

        private void ServerStart()
        {
            while (datos.Online)
            {
                Cliente = Server.AcceptTcpClient();
                Byte[] sms = new Byte[15000];
                NetworkStream Stream = Cliente.GetStream();
                Stream.Read(sms, 0, sms.Length);
                Terminales t = new Terminales(Cliente);
                EnviarDatos(Stream,serial.LoadMensaje(sms),t);
            }
        }

        private void EnviarDatos(NetworkStream stream,Mensaje ms,Terminales t)
        {
            if (ms.Prioridad != 5)
            {
                t.IDTerminal = ms.Prioridad;
                t.CajaInicial = conexion.CajaInicial(t.IDTerminal);
                datos.getTerminales().Add(stream, t.IDTerminal);
                t.EnviarDatosTerminal();
            }
            else
            {
                t.EnviarDatosDeposito(1);
            }
        }
        public void CloseThreard()
        {
            datos.Online = false;
            Hilo.Abort();
        }
        
    }
}
