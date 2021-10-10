using System;
using System.Data;
using CapaSoporte;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ValidarUsuario:CD_EjecutarSQL
    {
        private DataTable DT;
        public string Usuario { private get; set; }

        public bool ValidarUsuario()
        {
            //busco en la BD coincidencia de usuario para saber si existe, previo a consultar la coincidencia con la contraseña
            string query = $"SELECT * FROM Usuarios WHERE Usuario = '{Usuario}';";
            using (DT = new DataTable())
            {
                DT = ModoConectado(query);
                if (DT.Rows.Count != 0)
                {
                    return true;
                }
                else return false;
            }                
        }
    }
}
