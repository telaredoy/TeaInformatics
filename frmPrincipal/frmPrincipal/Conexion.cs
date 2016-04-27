using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace frmPrincipal
{
    class Conexion
    {
        #region VARIABLES
        private OleDbConnection DBconexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Dropbox\frmPrincipal\MultiRubro\BDDMultiRubro.accdb");

        #endregion
        private static Conexion instance = null;
        private Conexion() 
        {
           DBconexion.Open();
        }
        public static Conexion getintance()
        {
            if (instance == null)
            {
                instance = new Conexion();
            }
            return instance;
        }
        public void CargarStock(int Codigo, int Cantidad)
        {
            int Cant = 0;
            int Cant_P = 0;
            string consulta = "Select * FROM Productos where Cod_Producto = " + Codigo + "";
            OleDbCommand DBcomnado = new OleDbCommand(consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                Cant = Convert.ToInt32(DBdatareader["Cantidad"].ToString());
                Cant_P = Convert.ToInt32(DBdatareader["Cantida_Particionable"].ToString());
            }
            int total = (Cant * Cant_P) + Cantidad;
            Cant = total / Cant_P;
            consulta = "Update Productos set Cantidad = " + Cant + ", Cantidad_Total = " + total + " where Cod_Producto = " + Codigo + "";
            DBcomnado = new OleDbCommand(consulta, DBconexion);
            DBdatareader = DBcomnado.ExecuteReader();
        }
        public OleDbDataReader ConsultaDatos(string Consulta)
        {
            OleDbCommand DBcomnado = new OleDbCommand(Consulta , DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            return DBdatareader;
        }
        public bool InsertarDatos(string Consulta)
        {

            OleDbCommand DBcomnado = new OleDbCommand(Consulta, DBconexion);
            OleDbDataReader DBdatareader;

            try
            {
                DBdatareader = DBcomnado.ExecuteReader();
                return true;
            }
            catch
            {

                return false;
            }
        }
        internal string ObtenerProveedor(int p)
        {
            string aux = "";
            OleDbCommand DBcomnado = new OleDbCommand("Select * from Proveedores where Cod_Proveedor = "+p+"", DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                aux = DBdatareader["Nombre_RazonSocial"].ToString();
            }
            return aux;
        }
        internal string ObtenerUsuario(int p)
        {
            string aux = "";
            OleDbCommand DBcomnado = new OleDbCommand("Select * from Usuarios,Cajeros where Usuarios.Id_User = " + p + " and Usuarios.IdCajero = Cajeros.IdCajero", DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                aux = DBdatareader["Nombre"].ToString() + " " + DBdatareader["Apellido"].ToString();
            }
            return aux;
        }
        public void ConexionesRestablecer()
        {
            if (DBconexion.State == ConnectionState.Open)
            {
                DBconexion.Close();
                DBconexion.Open();
            }
        }
        public Hashtable LLenarComboBox(string _consulta, string Tabla1, string Tabla2)
        {
            Hashtable aux = new Hashtable();
            OleDbCommand DBcomnado = new OleDbCommand(_consulta, DBconexion);
            OleDbDataReader DBdatareader;
            DBdatareader = DBcomnado.ExecuteReader();
            while (DBdatareader.Read())
            {
                if (aux.ContainsKey(DBdatareader[Tabla2].ToString()))
                {
                    continue;
                }
                else
                {
                    aux.Add(DBdatareader[Tabla2].ToString(), DBdatareader[Tabla1].ToString());
                }
            }
            return aux;
        }
        ~Conexion()
        {
        }
    }
}
