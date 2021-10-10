using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaLogica
{
    public class CL_ValidarLogin
    {
        CD_ValidarUsuarioYClave CDUsuarioyClave;
        CD_ValidarUsuario CDUsuario;
        int intentos =1;
        public string Usuario { private get; set ; }
        public string Clave { private get; set; }

        public string ValidarLogin()
        {
            CDUsuario = new CD_ValidarUsuario();
            CDUsuario.Usuario = this.Usuario;
            if (CDUsuario.ValidarUsuario())
            {
                CDUsuarioyClave = new CD_ValidarUsuarioYClave();
                CDUsuarioyClave.Usuario = this.Usuario;
                CDUsuarioyClave.Clave = this.Clave;
                bool coinciden = CDUsuarioyClave.ValidarUsuarioYContraseña();
                if (coinciden) return "Login Exitoso";
                else
                {
                    intentos++;
                    if (intentos < 3) return "Clave Incorrecta";
                    else return ("Usuario Bloqueado");
                } 
                            
            }
            else return "Usuario Inexistente";            
        }
    }
}
