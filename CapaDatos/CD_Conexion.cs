using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public abstract class CD_Conexion
    {
        private readonly string cadena;

        public CD_Conexion()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|BDLogin.accdb; Persist Security Info=False;";
        }

        protected OleDbConnection Conectar()
        {
            return new OleDbConnection(cadena);
        }
    }
}
