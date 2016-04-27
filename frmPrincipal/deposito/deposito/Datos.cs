using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
namespace deposito
{
    class Datos
    {
        public bool autentificado { get; set; }
        private DataTable dt_Proveedores;
        private DataTable dt_Productos;
        private static Datos instance = null;
        private Datos() 
        {

        }
        public static Datos getDatos()
        {
            if (instance == null)
            {
                instance=new Datos();
            }
            return instance;
        }
        public void setProductos(DataTable dt)
        {
            dt_Productos = dt;
        }
        public void setProveedores(DataTable dt)
        {
            dt_Proveedores = dt;
        }
        public DataTable getProductos()
        {
            return dt_Productos;
        }
        public DataTable getProveedores()
        {
            return dt_Proveedores;
        }
    }
}
