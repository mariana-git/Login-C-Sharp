using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaSoporte;

namespace CapaDatos.Login
{
    public class CD_CambioDirectorio
    {
        public CD_CambioDirectorio(int directorio)
        {
            string query = $"UPDATE Usuarios SET IDDirectorio = {directorio} WHERE IDUsuario = {CS_UsuarioActivo.IDUsuario};";
            new CD_EjecutarNonQuery().EjecutarNonQuery(query);
        }
    }
}
