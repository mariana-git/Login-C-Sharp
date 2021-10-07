using System;
using System.Configuration;
using System.Data;
using CapaSoporte;

namespace CapaDatos
{
    public class CD_ValidarLogin
    {
        private DataTable DT = new DataTable();
        private string usuario, clave;
        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }

        public bool ValidarUsuario()
        {
            //busco en la BD coincidencia de usuario y clave (por ahora todo expuesto, sin encriptar)
            string query = $"SELECT * FROM Usuarios u INNER JOIN Personas p ON u.IDPersona = p.IDPersona WHERE Usuario = '{Usuario}' AND Clave = '{Clave}';";
            DT = new CD_EjecutarSQL().ModoConectado(query);
            if (DT.Rows.Count != 0)
            {
                //si existe el usuario, ademas de devolver true, cargo en la Capa Soporte los datos del usuario 
                CS_UsuarioActivo.IDUsuario = Convert.ToInt32(DT.Rows[0][0]);
                CS_UsuarioActivo.IDPersona = Convert.ToInt32(DT.Rows[0][1]);
                CS_UsuarioActivo.IDCargo = Convert.ToInt32(DT.Rows[0][20]);
                CS_UsuarioActivo.Nombre = Convert.ToString(DT.Rows[0][8]);
                CS_UsuarioActivo.Apellido = Convert.ToString(DT.Rows[0][9]);
                CS_UsuarioActivo.Email = Convert.ToString(DT.Rows[0][18]);
                return true;
            }
            else return false;
        }
        
    }
}
