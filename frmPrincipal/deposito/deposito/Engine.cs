using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serial;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace deposito
{
    class Engine
    {
        #region Objetos privados
        private static Engine instance = null;
        private Class1 serial = new Class1();
        private Send send = Send.GetSend();
        private Datos datos = Datos.getDatos();
        private TcpClient Cliente;
        private NetworkStream StreamCliente;
        private Thread Hilo;
        private bool Online;
        private string IP;
        private int Port;
        private int IDTerminal;
        private bool Connected;
        #endregion 
        #region Formularios
        private Imprimir imprimir;

        public Imprimir Imprimir
        {
            get { return imprimir; }
            set { imprimir = value; }
        }
        private frm_deposito Deposito;

        public frm_deposito Deposito1
        {
            get { return Deposito; }
            set { Deposito = value; }
        }
        private frm_ABProductos Ab_Productos;

        public frm_ABProductos Ab_Productos1
        {
            get { return Ab_Productos; }
            set { Ab_Productos = value; }
        }
        private frm_CargarStock CargaStock;

        public frm_CargarStock CargaStock1
        {
            get { return CargaStock; }
            set { CargaStock = value; }
        }
        private frm_DevolucionStock Devolucion_;

        public frm_DevolucionStock Devolucion_1
        {
            get { return Devolucion_; }
            set { Devolucion_ = value; }
        }
        private frm_Login Login;

        public frm_Login Login1
        {
            get { return Login; }
            set { Login = value; }
        }
        private frm_NuevoProveedor NuevoProveedor;

        public frm_NuevoProveedor NuevoProveedor1
        {
            get { return NuevoProveedor; }
            set { NuevoProveedor = value; }
        }
        private frm_PreDevolucion PreDevolucion;

        public frm_PreDevolucion PreDevolucion1
        {
            get { return PreDevolucion; }
            set { PreDevolucion = value; }
        }
        #endregion Formularios
        private Engine()
        {
            IniciarConexion();
        }
        public static Engine getInstance()
        {
            if (instance == null)
            {
                instance = new Engine();
            }
            return instance;
        }
        private void IniciarConexion()
        {
            Connected = false;
            try
            {
                System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader("c:\\Deposito.xml");
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
            }
            catch
            {
                MessageBox.Show("Error al cargar configuracion de conexion");

            }

            //Conectando con servidor
            try
            {
                Cliente = new TcpClient(this.IP, this.Port);
                StreamCliente = Cliente.GetStream();
                Connected = true;
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Error 100 - Sin conexion al servidor ¿Intentar Reconectar?", "Sin conexion a el servidor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    IniciarConexion();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //###############################

            //Cargando Conexion para canal de datos
            send.Cliente1 = Cliente;
            send.StreamCliente1 = StreamCliente;
            //###############################

            //Generar Mensaje de arranque de terminal
            Mensaje msj = new Mensaje();
            msj.NombreTerminal = "Deposito";
            msj.Prioridad = IDTerminal;
            msj.op = 16;
            EnviarMensaje(msj);
            //###############################

            //Iniciando Hilo SubProceso
            this.Hilo = new Thread(SubProceso);
            this.Online = true;
            this.Hilo.IsBackground = true;
            this.Hilo.Start();
            //###############################


        }
        private void SubProceso(object obj)
        {
            int contador = 0;
            while (Connected)
            {
                if (contador == 5)
                {
                    MessageBox.Show("Se ha llegado al maximo de intentos posible. \n la aplicación se cerrara. \n En caso que el problema persista comuniquese con su proveedor de sistemas.");
                    Connected = false;
                    continue;
                }
                byte[] msj = new byte[20000000];
                try
                {
                    StreamCliente = Cliente.GetStream();
                    StreamCliente.Read(msj, 0, msj.Length);
                }
                catch
                {
                    MessageBox.Show("Conexion perdida");
                    contador++;
                    continue;
                }
                Mensajes(serial.LoadMensaje(msj));
            }
            Application.Exit();
        }
        private void Mensajes(Mensaje msj)
        {
            switch (msj.op)
            {
                case 1:
                    datos.setProductos(msj.dt_Productos);
                    datos.setProveedores(msj.dt_Aux);                    
                    Deposito.lb_Actualizado.Text = DateTime.Now.ToLocalTime().ToString();
                    break;
                case 2:
                    if (msj.Correcto)
                    {
                        datos.autentificado = true;
                    }
                    else
                    {
                        Login.ErrorConectar();
                    }
                    break;
                case 3:
                    Ab_Productos.CargarProducto(msj.producto);
                    break;
                case 4:
                    imprimir.CargarDatatable(msj.dt_Productos);
                    break;
                case 5:
                    datos.setProductos(msj.dt_Productos);
                    datos.setProveedores(msj.dt_Aux);
                    Ab_Productos.Actualizar();
                    Deposito.lb_Actualizado.Text = DateTime.Now.ToLocalTime().ToString();
                    break;
                case 6:
                    Devolucion_1.CargarDatatable(msj.dt_Aux);
                    break;
            }
        }
        public Datos getDatos()
        {
            return datos;
        }
        public void EnviarMensaje(Mensaje obj)
        {
            try
            {
                send.EnviarMensaje(serial.SerializarObj(obj));
            }
            catch
            {
                MessageBox.Show("Error al enviar datos intentelo nuevamente");
            }
        }

    }
}
