using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace deposito
{
    class Send
    {
        private TcpClient Cliente;

        public TcpClient Cliente1
        {
            get { return Cliente; }
            set { Cliente = value; }
        }
        private NetworkStream StreamCliente;

        public NetworkStream StreamCliente1
        {
            get { return StreamCliente; }
            set { StreamCliente = value; }
        }
        private static Send send = null;
        private Send()
        {

        }
        public static Send GetSend()
        {
            if (send == null)
            {
                send = new Send();
            }
            return send;
        }
        public void EnviarMensaje(byte[] bytes)
        {
            try
            {
                byte[] data = bytes;
                StreamCliente.Write(data, 0, data.Length);
                StreamCliente.Flush();
            }
            catch
            {
                MessageBox.Show("Error al enviar datos");
            }
        }
    }
}
