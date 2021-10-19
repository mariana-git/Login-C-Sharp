using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_BloquearUsuario :CD_EjecutarNonQuery
    {
        public CD_BloquearUsuario(int idusuario)
        {
            //paso a Directorio "Bloqueado" al ususario y seteo la fecha de hoy
            string query = $"UPDATE Usuarios SET IDDirectorio = 3, FechaBloqueo =  Date() WHERE IDUsuario = {idusuario};";
            EjecutarNonQuery(query);
        }
    }
}
