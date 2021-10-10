using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaLogica
{
    public class CL_ValidarLogin
    {
        CD_ValidarLogin CDLogin;
        CD_ValidarUsuario CDUsuario;
        CL_IntentosLogin CLIntentos;
        public string Usuario { private get; set ; }
        public string Clave { private get; set; }

        public string ValidarLogin()
        {
            CDUsuario = new CD_ValidarUsuario();
            CDUsuario.Usuario = this.Usuario;
            if (CDUsuario.ValidarUsuario())
            {
                CDLogin = new CD_ValidarLogin();
                CDLogin.Usuario = this.Usuario;
                CDLogin.Clave = this.Clave;
                bool existe = CDLogin.ValidarUsuarioYContraseña();
                if (existe) return "Login Exitoso";
                else return "Clave Incorrecta";                
            }
            else return "Usuario Inexistente";            
        }
    }
}
