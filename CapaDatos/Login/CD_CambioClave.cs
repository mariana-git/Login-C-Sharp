
using CapaSoporte;
namespace CapaDatos.Login
{
    public class CD_CambioClave: CD_EjecutarNonQuery
    {
        public CD_CambioClave(string clave)
        {
            string query= $"UPDATE Usuarios SET Clave = '{clave}', FechaUltCambio = Date() WHERE IDUsuario = {CS_UsuarioActivo.IDUsuario};";
            new CD_EjecutarNonQuery().EjecutarNonQuery(query);
        }
    }
}
