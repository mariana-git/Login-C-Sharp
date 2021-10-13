using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class CD_EjecutarReader: CD_Conexion
    {
        public DataTable ExecuteReader(string query)
        {
            //Método para realizar todas las consultas en modo casi-conectado
            using (OleDbConnection Conexion = Conectar())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (OleDbCommand Comando = new OleDbCommand(query, Conexion))
                {
                    Comando.CommandTimeout = 15;
                    OleDbDataReader leer = Comando.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }        
    }
}
