using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Login
{
    public class CD_BuscarUsuarios
    {
        public DataTable ConParametros(string palabra)
        {
            //busqueda con parámetros de tipo texto
            string query = $"SELECT * FROM (Personas p INNER JOIN Usuarios u ON u.IDPersona = p.IDPersona) INNER JOIN Cargos c ON c.IDcargo=p.IDCargo  " +
                             $"  WHERE p.Nombre LIKE '%{palabra}%'  OR Apellido LIKE '*{palabra}*' OR Usuario LIKE '*{palabra}*' OR Email LIKE '*{palabra}*' " +
                             $"OR c.Nombre LIKE '*{palabra}*' ;";

            return Buscar(query);
        }
        public DataTable ConParametros(int numero)
        {
            //busqueda con parámetros de tipo numérico
            //string query = $"SELECT * FROM (Personas p INNER JOIN Usuarios u ON u.IDPersona = p.IDPersona) INNER JOIN Cargos c ON c.IDcargo=p.IDCargo  " +
            //    $"  WHERE p.IDPersona LIKE '*{numero}*' OR IDUsuario LIKE '*{numero}*' OR c.IDCargo LIKE '*{numero}*' OR IntentosLogin LIKE '*{numero}*' OR " +
            //    $"FrecuenciaCambio LIKE '*{numero}*' OR IDDirectorio LIKE '*{numero}*';";
            string query = $"SELECT * FROM (Personas p INNER JOIN Usuarios u ON u.IDPersona = p.IDPersona) INNER JOIN Cargos c ON c.IDcargo=p.IDCargo  " +
                $"WHERE p.IDPersona LIKE '%2%' OR IDUsuario LIKE '%2%' ;";
            return Buscar(query);
        }
        public DataTable SinParametros()
        {
            //busqueda sin parámetros
            string query = $"SELECT * FROM (Personas p INNER JOIN Usuarios u ON u.IDPersona = p.IDPersona) INNER JOIN Cargos c ON c.IDcargo=p.IDCargo ;";
            return Buscar(query);
        }
        private DataTable Buscar(string query)
        {
            using (DataTable DT = new CD_EjecutarReader().EjecutarReader(query))
            {
                return DT;
            }
        }
    }
}
