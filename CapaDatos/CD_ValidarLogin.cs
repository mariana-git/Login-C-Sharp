using System;
using System.Configuration;
using System.Data;
using CapaSoporte;

namespace CapaDatos
{
    public class CD_ValidarLogin: CD_EjecutarSQL
    {
        private DataTable DT = new DataTable();
        public string Usuario { private get; set; }
        public string Clave { private get; set; }

        public bool ValidarUsuarioYContraseña()
        {
            //busco en la BD coincidencia de usuario y clave (por ahora todo expuesto, sin encriptar)
            string query = $"SELECT * FROM Usuarios u INNER JOIN Personas p ON u.IDPersona = p.IDPersona WHERE Usuario = '{Usuario}' AND Clave = '{Clave}';";
            DT = ModoConectado(query);
            if (DT.Rows.Count != 0)
            {
                //si existe el usuario, ademas de devolver true, cargo en la Capa Soporte los datos del usuario 
                CS_UsuarioActivo.IDUsuario = Convert.ToInt32(DT.Rows[0][0]);
                CS_UsuarioActivo.IDPersona = Convert.ToInt32(DT.Rows[0][1]);
                CS_UsuarioActivo.IDCargo = Convert.ToInt32(DT.Rows[0][12]);
                CS_UsuarioActivo.Nombre = Convert.ToString(DT.Rows[0][7]);
                CS_UsuarioActivo.Apellido = Convert.ToString(DT.Rows[0][8]);
                CS_UsuarioActivo.Email = Convert.ToString(DT.Rows[0][11]);
                return true;
            }
            else return false;
        }
        
    }
}
