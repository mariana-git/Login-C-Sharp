using System;
using System.Data;
using CapaSoporte;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_IntentosLogin
    {        
        public CD_IntentosLogin(int intento, int idusuario)
        {
            string query = $"UPDATE Usuarios SET IntentosLogin = { intento } WHERE IDUsuario = {idusuario};";
            new CD_EjecutarNonQuery().EjecutarNonQuery(query);
        }
  
    }
}
