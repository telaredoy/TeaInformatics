using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    class Send
    {
        public TcpClient Cliente;
        public NetworkStream StreamCliente;
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
                Byte[] data = bytes;
                StreamCliente.Write(data, 0, data.Length);
                StreamCliente.Flush();
            }
            catch
            {
                MessageBox.Show("Error en enviar datos");
            }
        }
    }
}
