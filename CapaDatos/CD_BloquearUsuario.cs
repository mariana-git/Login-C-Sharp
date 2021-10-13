using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_BloquearUsuario :CD_EjecutarNonQuery
    {

        public string Usuario { private get; set; }

        public int Bloquear()
        {
            //busco en la BD coincidencia de usuario y clave 
            //string query = $"UPDATE Usuarios SET Bloqueado = True WHERE Usuario = 'd';";
            string query = $"select count(*) from Usuarios;";
            return EjecutarNonQuery(query);
        }
    }
}
