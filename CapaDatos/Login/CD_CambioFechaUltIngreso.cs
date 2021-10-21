using System;
using CapaSoporte;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Login
{
    public class CD_CambioFechaUltIngreso
    {
        public CD_CambioFechaUltIngreso ()
        {
            string query = $"UPDATE Usuarios SET FechaUltIngreso = Date() WHERE IDUsuario = {CS_UsuarioActivo.IDUsuario}";
            new CD_EjecutarNonQuery().EjecutarNonQuery(query);
        }
    }
}
