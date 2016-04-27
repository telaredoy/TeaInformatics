using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serial
{
    [Serializable]
    public class Cliente
    {
        public string NombreRazonSocial;
        public string Cuit_Cuil;
        public string Direccion;
        public string Ciudad;
        public string Telefono;
        public string Nombre_Responsable;
        public string Telefono_Responsable;
        public string Email;
        public int Cod_Cliente;
        public Cliente(int _Cod_Cliente, string _NombreRazonSocial, string _Cuit_Cuil, string _Direccion, string _Telefono, string _Email, string _Ciudad, string _NombreResponsable, string _TelefonoResponsable)
        {
            this.Ciudad = _Ciudad;
            this.Cod_Cliente = _Cod_Cliente;
            this.Cuit_Cuil = _Cuit_Cuil;
            this.Direccion = _Direccion;
            this.Email = _Email;
            this.Nombre_Responsable = _NombreResponsable;
            this.NombreRazonSocial = _NombreRazonSocial;
            this.Telefono = _Telefono;
            this.Telefono_Responsable = _TelefonoResponsable;
        }
        public Cliente(string _NombreRazonSocial, string _Cuit_Cuil, string _Direccion, string _Telefono, string _Email, string _Ciudad, string _NombreResponsable, string _TelefonoResponsable)
        {
            this.Ciudad = _Ciudad;
            this.Cuit_Cuil = _Cuit_Cuil;
            this.Direccion = _Direccion;
            this.Email = _Email;
            this.Nombre_Responsable = _NombreResponsable;
            this.NombreRazonSocial = _NombreRazonSocial;
            this.Telefono = _Telefono;
            this.Telefono_Responsable = _TelefonoResponsable;
        }
    }
}
