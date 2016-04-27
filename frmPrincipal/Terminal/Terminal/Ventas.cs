using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Terminal
{
    class Ventas
    {
        public DataTable dt_Ventas;
        public static Ventas instance = null;
        private Ventas()
        {
            dt_Ventas = new DataTable();
            CargarDataTable();
        }
        public static Ventas getInstance()
        {
            if (instance == null)
            {
                instance = new Ventas();
            }
            return instance;
        }
        private void CargarDataTable()
        {
            dt_Ventas.Columns.Add("Hora");
            dt_Ventas.Columns.Add("Ticket/Retiro");
            dt_Ventas.Columns.Add("Ticket Nº/Retiro Nº");
            dt_Ventas.Columns.Add("Empleado");
            dt_Ventas.Columns.Add("Monto");
        }
        public void CargarVenta(int NumeroTicket, double Monto, string User, string Hora)
        {
            DataRow dr = dt_Ventas.NewRow();
            dr[0] = Hora;
            dr[1] = "Ticket";
            dr[2] = NumeroTicket;
            dr[3] = User;
            dr[4] = Monto;
            dt_Ventas.Rows.Add(dr);
        }
        public void CargarRetiro(int idRetiro,double Monto, string User, string Hora)
        {
            DataRow dr = dt_Ventas.NewRow();
            dr[0] = Hora;
            dr[1] = "Retiro";
            dr[2] = idRetiro;
            dr[3] = User;
            dr[4] = Monto;
            dt_Ventas.Rows.Add(dr);     
        }
    }
}
