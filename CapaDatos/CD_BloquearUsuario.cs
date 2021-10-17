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
            //busco en la BD coincidencia de usuario y clave 
            //string query = $"UPDATE Usuarios SET Bloqueado = True WHERE Usuario = 'd';";
            string query1 = $"UPDATE Usuarios SET IDDirectorio = 3 WHERE IDUsuario = {idusuario};";
            EjecutarNonQuery(query1);
            string query2 = $"UPDATE Usuarios SET FechaBlqoueo = GETDATE() WHERE IDUsuario = {idusuario};";
            EjecutarNonQuery(query2);

        }
    }
}
