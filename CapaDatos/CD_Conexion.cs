using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public abstract class CD_Conexion
    {
        private readonly OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|BDLogin.accdb; Persist Security Info=False;");

        public OleDbConnection Conectar()
        {
            if (Conexion.State == ConnectionState.Open) Conexion.Close();
            Conexion.Open();
            return Conexion;
        }

        public OleDbConnection Desconectar()
        {
            Conexion.Close();
            return Conexion;
        }
    }
}
