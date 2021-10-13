using System;
using System.Collections.Generic;
using System.Linq;
using CapaSoporte;
using CapaDatos;

namespace CapaLogica
{
    public class CL_ValidarLogin
    {
        CL_IntentosLogin intentos;

        public string Usuario { private get; set ; }
        public string Clave { private get; set; }

        public string ValidarLogin()
        {
            intentos = new CL_IntentosLogin(Usuario); //clase que valida la cantidad de intentos
            CD_ValidarNombreUsuario ValidaUsuarioCD = new CD_ValidarNombreUsuario();
            if (ValidaUsuarioCD.NombreUsuario(Usuario))   //valido que exista el usuario
            {
                CD_ValidarLogin ValidaLoginCD = new CD_ValidarLogin(Usuario,Clave);
                if (ValidaLoginCD.Existe) return "Login Exitoso"; //valido que coincidan usuario y contraseña
                else
                {
                    
                    if (intentos.Permitir) return "Clave Incorrecta";  //valido la cantidad de intentos incorrectos
                    else
                    {
                        CD_BloquearUsuario BloquearCD = new CD_BloquearUsuario();
                        BloquearCD.Usuario = Usuario;
                        int filas = BloquearCD.Bloquear();  //bloquear usuario
                        return $"Usuario Bloqueado {filas} afectadas";
                    }                         
                }
            }
            else return "Usuario Inexistente";
            //if (CDUsuario.ValidarUsuario())
            //{
            //    CDUsuarioyClave = new CD_ValidarLogin();
            //    CDUsuarioyClave.Usuario = this.Usuario;
            //    CDUsuarioyClave.Clave = this.Clave;
            //    bool coinciden = CDUsuarioyClave.ValidarUsuarioYContraseña();
            //    if (coinciden) return "Login Exitoso";
            //    else return "Clave Incorrecta";        
            //}
            //else return "Usuario Inexistente";            
        }       
    }
}
