using System;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class CD_EjecutarEscalar : CD_Conexion
    {
        public int EjecutarEscalar(string query)
        {
            //Método para realizar todas las consultas en modo desconectado
            using (OleDbConnection Conexion = Conectar())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (OleDbCommand Comando = new OleDbCommand(query, Conexion))
                {
                    if (Comando.ExecuteScalar() == null) return 0;
                    else return 1;
                }
            }
        }
    }
}
