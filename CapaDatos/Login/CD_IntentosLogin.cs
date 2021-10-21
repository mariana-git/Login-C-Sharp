using System;
using System.Data;
using CapaSoporte;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Login
{
    public class CD_IntentosLogin
    {        
        public CD_IntentosLogin(int intento)
        {
            string query = $"UPDATE Usuarios SET IntentosLogin = { intento }, FechaUltIntento =  Date() WHERE IDUsuario = {CS_UsuarioActivo.IDUsuario};";
            new CD_EjecutarNonQuery().EjecutarNonQuery(query);
        }
  
    }
}
