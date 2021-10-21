using CapaSoporte;

namespace CapaDatos.Login
{
    public class CD_BloquearUsuario :CD_EjecutarNonQuery
    {
        public CD_BloquearUsuario()
        {
            //paso a Directorio "Bloqueado" al ususario y seteo la fecha de hoy
            string query = $"UPDATE Usuarios SET IDDirectorio = 3, FechaBloqueo =  Date() WHERE IDUsuario = {CS_UsuarioActivo.IDUsuario};";
            EjecutarNonQuery(query);
        }
    }
}
