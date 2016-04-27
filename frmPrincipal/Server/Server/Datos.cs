using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Server
{
    class Datos
    {
        public static Datos instance = null;
        private int TicketN;
        private int RetiroN;
        public bool Online { get; set; }
        private Hashtable Terminales;
        private Conexion conexion = Conexion.getintance();
        private Datos()
        {
            getNTicket();
            getNRetiro();
        }

        private void getNRetiro()
        {
            RetiroN = conexion.GenerarRetiroN();
        }
        public Hashtable getTerminales()
        {
            return Terminales;
        }
        public void setTerminales(Hashtable Terminales)
        {
            this.Terminales = Terminales;
        }
        public static Datos getDatos()
        {
            if (instance == null)
            {
                instance = new Datos();
            }
            return instance;
        }
        private int getNTicket()
        {
            TicketN = conexion.GenerarTicket();
            return TicketN;
        }
        public int getTicket(int IDTerminal)
        {
            int ticket = TicketN;
            conexion.CargarTicket(IDTerminal,ticket);
            TicketN++;
            return ticket;
        }
        public int getRetiro(int IDTerminal)
        {
            int Retiro = RetiroN;
            conexion.CargarRetiro(IDTerminal, Retiro);
            RetiroN++;
            return Retiro;
        }
    }
}
