using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_BloquearUsuario :CD_EjecutarSQL
    {
        private string usuario;

        public string Usuario { get => usuario; set => usuario = value; }

        public void Bloquear()
        {
            //busco en la BD coincidencia de usuario y clave 
            string query = $"UPDATE Usuarios SET Bloqueado = -1 WHERE Usuario = '{Usuario}';";
            ModoDesconectado(query);
        }
    }
}
