namespace CapaDatos
{
    public class CD_ValidarLogin
    {        
        public bool NombreUsuario(string usuario)
        {
            //busco en la BD coincidencia de usuario para saber si existe, previo a consultar la coincidencia con la contraseña
            string query = $"SELECT * FROM Usuarios WHERE Usuario = '{usuario}';";

            if (new CD_EjecutarEscalar().EjecutarEscalar(query) == 0) return false;
            else return true;            
        }

        public bool UsuarioYClave(string usuario, string clave)
        {
            //busco en la BD coincidencia de usuario y clave
            string query = $"SELECT * FROM Usuarios WHERE Usuario = '{usuario}' AND Clave = '{clave}';";
            
            if (new CD_EjecutarEscalar().EjecutarEscalar(query) == 0) return false;
            else return true;
        }
    }
}
