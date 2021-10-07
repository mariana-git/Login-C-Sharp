using System;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class CD_EjecutarSQL: CD_Conexion
    {
        private DataTable DT = new DataTable();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataReader leer;
        public void ModoDesconectado(string query)
        {
            //Método para realizar todas las consultas en modo conectado
            Comando.Connection = Conectar();
            Comando.CommandText = query;
            Comando.ExecuteNonQuery();
            Desconectar();
        }

        public DataTable DTModoConectado(string query)
        {
            Comando.Connection = Conectar();
            Comando.CommandText = query;
            Comando.CommandTimeout = 15;
            leer = Comando.ExecuteReader();
            DT.Load(leer);
            //if (DT.Rows.Count == 0) throw new Exception("LA BÚSQUEDA NO ARROJÓ RESULTADOS\n\n\n\n");
            Desconectar();
            return DT;
        }

        public bool BoolModoConectado(string query)
        {
            Comando.Connection = Conectar();
            Comando.CommandText = query;
            Comando.CommandTimeout = 15;
            leer = Comando.ExecuteReader();
            DT.Load(leer);
            Desconectar();
            if (DT.Rows.Count == 0) return false;
            else return true;
        }
    }
}
