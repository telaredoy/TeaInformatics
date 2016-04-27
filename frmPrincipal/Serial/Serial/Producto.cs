using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serial
{
    [Serializable]
    public class Producto
    {
        public Int64 Codigo { get; set; }
        public int CodigoProveedor { get; set; }
        public int Cantidad { get; set; }
        public int Cantidad_Particionable { get; set; }
        public int Cantidad_Total { get; set; }
        public int StockCritico { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioVenta { get; set;}
        public double Ganancia { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionTicket { get; set; }
        public string Rubro { get; set; }
    }
}
