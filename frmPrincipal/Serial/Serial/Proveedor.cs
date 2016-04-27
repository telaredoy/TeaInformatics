using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serial
{
    [Serializable]
    public class Proveedor
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
