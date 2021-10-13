using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ValidarNombreUsuario: CD_EjecutarEscalar
    {
        public bool NombreUsuario(string usuario)
        {
            //busco en la BD coincidencia de usuario para saber si existe, previo a consultar la coincidencia con la contraseña
            string query = $"SELECT * FROM Usuarios WHERE Usuario = '{usuario}';";
            //string query = "SELECT Count(*) FROM Usuarios WHERE Usuario = 'd';";
            //int nombre = ExecuteNonQuery(query);
            
            int f = EjecutarEscalar(query);
            if ( f == 0) return false;
            else return true;
        }
    }
}
