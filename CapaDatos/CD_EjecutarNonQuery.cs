using System;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class CD_EjecutarNonQuery: CD_Conexion
    {
        internal int EjecutarNonQuery(string query)
        {
            //Método para realizar todas las consultas en modo desconectado
            using (OleDbConnection Conexion = Conectar())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (OleDbCommand Comando = new OleDbCommand(query, Conexion))
                {                    
                    return Comando.ExecuteNonQuery();
                }
            }
        }       
    }
}
