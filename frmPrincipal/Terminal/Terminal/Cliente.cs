using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terminal
{
    public class Cliente
    {
        private string Nombre;
        private string Cuit;
        private string Direccion;
        private string Ciudad;
        private int id;
        public Cliente(int _id,string _Nombre, string _Cuit, string _Direccion, string _Ciudad)
        {
            this.id = _id;
            this.Nombre = _Nombre;
            this.Cuit = _Cuit;
            this.Direccion = _Direccion;
            this.Ciudad = _Ciudad;
        }
    }
}
