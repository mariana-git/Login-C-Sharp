using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class CD_ValidarLogin
    {
        private DataTable DT = new DataTable();
        private string usuario, clave;
        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }

        public bool ValidarUsuario()
        {
            string query = $"SELECT * FROM Usuarios WHERE Usuario ='{Usuario}' AND Clave = '{Clave}';";

            bool existe = new CD_EjecutarSQL().BoolModoConectado(query);
            if(existe) return true;
            else return false;
        }
        
    }
}
