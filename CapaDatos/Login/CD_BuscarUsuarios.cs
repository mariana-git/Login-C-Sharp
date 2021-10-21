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
            //busqueda con parámetros
            //string query = $"SELECT * FROM (Personas p INNER JOIN Usuarios u ON u.IDPersona = p.IDPersona) INNER JOIN Cargos c ON c.IDcargo=p.IDCargo  " +
            //    $"  WHERE p.Nombre LIKE '*{palabra}*' OR Apellido LIKE '*{palabra}*' OR p.IDPersona LIKE '*{palabra}*' OR IDUsuario LIKE '*{palabra}*' OR " +
            //    $"Usuario LIKE '*{palabra}*' OR Email LIKE '*{palabra}*' OR c.Nombre LIKE '*{palabra}*';";
            string query = $"SELECT * FROM (Personas p INNER JOIN Usuarios u ON u.IDPersona = p.IDPersona) INNER JOIN Cargos c ON c.IDcargo=p.IDCargo  " +
                             $"  WHERE p.Nombre LIKE '%{palabra}%'  OR Apellido LIKE '*{palabra}*' OR Usuario LIKE '*{palabra}*' OR Email LIKE '*{palabra}*' " +
                             $"OR c.Nombre LIKE '*{palabra}*' ;";

            //string query = $"SELECT * FROM Personas ;";
            using (DataTable DT = new CD_EjecutarReader().EjecutarReader(query))
            {
                return DT;
            }
        }
        public DataTable SinParametros()
        {
            //busqueda sin parámetros
            string query = $"SELECT * FROM (Personas p INNER JOIN Usuarios u ON u.IDPersona = p.IDPersona) INNER JOIN Cargos c ON c.IDcargo=p.IDCargo ;";
            using (DataTable DT = new CD_EjecutarReader().EjecutarReader(query))
            {
                return DT;
            }
        }
    }
}
