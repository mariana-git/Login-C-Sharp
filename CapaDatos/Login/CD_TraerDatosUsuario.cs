using CapaSoporte;
using System;
using System.Data;

namespace CapaDatos.Login
{
    public class CD_TraerDatosUsuario
    {
        public void DatosLogin(string usuario)
        {
            //busco en la BD coincidencia de usuario y traigo datos para validar intento
            string query = $"SELECT IDUsuario, IDDirectorio, IntentosLogin FROM Usuarios WHERE Usuario = '{usuario}';";
            using (DataTable DT = new CD_EjecutarReader().EjecutarReader(query))
            {
                //cargo en la Capa Soporte los datos del usuario 
                CS_UsuarioActivo.IDUsuario = Convert.ToInt32(DT.Rows[0][0]);
                CS_UsuarioActivo.IDDirectorio = Convert.ToInt32(DT.Rows[0][1]);
                CS_UsuarioActivo.IntentosLogin = Convert.ToInt32(DT.Rows[0][2]);                
            }
        }
        public void DatosUsuarioLogueado()
        {
            //busco en la BD coincidencia de usuario y clave (por ahora todo expuesto, sin encriptar)
            string query = $"SELECT u.IDPersona, Usuario, FrecuenciaCambio, FechaUltIngreso, FechaUltCambio, p.Nombre,Apellido, Email, p.IDCargo, c.Nombre FROM " +
                $"( Personas p INNER JOIN Usuarios u ON u.IDPersona = p.IDPersona) INNER JOIN Cargos c ON c.IDcargo=p.IDCargo  " +
                $"WHERE IDUsuario = {CS_UsuarioActivo.IDUsuario};";
            using (DataTable DT = new CD_EjecutarReader().EjecutarReader(query))
            {
                //cargo en la Capa Soporte los datos del usuario 
                CS_UsuarioActivo.IDPersona = Convert.ToInt32(DT.Rows[0][0]);
                CS_UsuarioActivo.Usuario = Convert.ToString(DT.Rows[0][1]);
                CS_UsuarioActivo.FrecuenciaCambio = Convert.ToInt32(DT.Rows[0][2]);
                CS_UsuarioActivo.FechaUltIngreso = Convert.ToDateTime(DT.Rows[0][3] is DBNull ? null : DT.Rows[0][3]);
                CS_UsuarioActivo.FechaUltCambio = Convert.ToDateTime(DT.Rows[0][4] is DBNull ? null : DT.Rows[0][4]);
                CS_UsuarioActivo.Nombre = Convert.ToString(DT.Rows[0][5]);
                CS_UsuarioActivo.Apellido = Convert.ToString(DT.Rows[0][6]);
                CS_UsuarioActivo.Email = Convert.ToString(DT.Rows[0][7]);
                CS_UsuarioActivo.IDCargo = Convert.ToInt32(DT.Rows[0][8]);
                CS_UsuarioActivo.Cargo = Convert.ToString(DT.Rows[0][9]);
            }
        }
    }    
}
