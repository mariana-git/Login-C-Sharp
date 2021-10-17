using System;
using System.Data;
using CapaSoporte;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_IntentosLogin
    {
        public CD_IntentosLogin(string usuario)
        {
            string query = $"SELECT * FROM Usuarios WHERE Usuario = '{usuario}';";
            DataTable DT = new DataTable();
            using (DT = new CD_EjecutarReader().EjecutarReader(query))
            {
                if (DT.Rows.Count != 0)
                {
                    //si existe el usuario, ademas de devolver true, cargo en la Capa Soporte los datos del usuario 
                    CS_UsuarioActivo.IDUsuario = Convert.ToInt32(DT.Rows[0][0]);
                    CS_UsuarioActivo.IDDirectorio = Convert.ToInt32(DT.Rows[0][5]);
                    CS_UsuarioActivo.IntentosLogin = Convert.ToInt32(DT.Rows[0][6]);
                }
            }
        }
        public CD_IntentosLogin(int intento, int idusuario)
        {
            string query = $"UPDATE Usuarios SET IntentosLogin = { intento } WHERE IDUsuario = {idusuario};";
            new CD_EjecutarNonQuery().EjecutarNonQuery(query);
        }
  
    }
}
