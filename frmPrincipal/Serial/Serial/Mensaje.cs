using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Serial
{
    [Serializable]
    public class Mensaje
    {
        public Proveedor proveedor { get; set; }
        public Producto producto { get; set; }
        public string Cuit_Cuil { get; set; }
        public DataTable dt_Aux { get; set; }
        public int IdRetiro { get; set; }
        public string Empleado { get; set; }
        public string Hora { get; set; }
        public double IVA { get; set; }
        public double CajaActual { get; set; }
        public double Monto { get; set; }
        public Cliente cliente { get; set; }
        public DataTable dt_Productos { get; set; }
        public DataTable dt_Clientes { get; set; }
        public DataTable dt_Venta { get; set; }
        public int IdCliente { get; set; }
        public int op { get; set; }
        public string NombreTerminal{ get; set; }
        public string _Mensaje { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Prioridad { get; set; }
        public bool Correcto { get; set; }
        public int N_Ticket { get; set; }
        public int Porcentaje { get; set; }
    }
}
