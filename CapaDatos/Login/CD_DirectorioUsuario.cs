using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Login
{
    public class CD_DirectorioUsuario
    {
        public CD_DirectorioUsuario(int directorio, int idusuario)
        {
            string query = $"UPDATE Usuarios SET IDDirectorio = {directorio} WHERE IDUsuario = {idusuario};";
            new CD_EjecutarNonQuery().EjecutarNonQuery(query);
        }
    }
}
