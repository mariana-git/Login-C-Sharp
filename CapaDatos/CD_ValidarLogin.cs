using System;
using System.Configuration;
using System.Data;
using CapaSoporte;

namespace CapaDatos
{
    public class CD_ValidarLogin
    {
        public void CargarDatosLogin(string usuario)
        {
            //busco en la BD coincidencia de usuario y clave (por ahora todo expuesto, sin encriptar)
            string query = $"SELECT * FROM Usuarios u INNER JOIN Personas p ON u.IDPersona = p.IDPersona WHERE Usuario = '{usuario}';";
            using (DataTable DT = new CD_EjecutarReader().EjecutarReader(query))                
            {
                //cargo en la Capa Soporte los datos del usuario 
                CS_UsuarioActivo.IDUsuario = Convert.ToInt32(DT.Rows[0][0]);
                CS_UsuarioActivo.IDPersona = Convert.ToInt32(DT.Rows[0][1]);
                CS_UsuarioActivo.Usuario = Convert.ToString(DT.Rows[0][2]);
                CS_UsuarioActivo.FCambio = Convert.ToInt32(DT.Rows[0][4]);
                CS_UsuarioActivo.IDDirectorio = Convert.ToInt32(DT.Rows[0][5]);
                CS_UsuarioActivo.IntentosLogin = Convert.ToInt32(DT.Rows[0][6]);
                CS_UsuarioActivo.FechaAlta = Convert.ToDateTime(DT.Rows[0][7]);
                CS_UsuarioActivo.FechaBaja = Convert.ToDateTime(DT.Rows[0][8] is DBNull ? null : DT.Rows[0][8]);
                CS_UsuarioActivo.FechaBloqueo = Convert.ToDateTime(DT.Rows[0][9] is DBNull ? null : DT.Rows[0][9]);
                CS_UsuarioActivo.FechaUltIngreso = Convert.ToDateTime(DT.Rows[0][10] is DBNull ? null : DT.Rows[0][10]);
                CS_UsuarioActivo.Nombre = Convert.ToString(DT.Rows[0][12]);
                CS_UsuarioActivo.Apellido = Convert.ToString(DT.Rows[0][13]);
                CS_UsuarioActivo.Email = Convert.ToString(DT.Rows[0][14]);
                CS_UsuarioActivo.IDCargo = Convert.ToInt32(DT.Rows[0][15] is DBNull ? 0 : DT.Rows[0][15]);
            }            
        }
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
