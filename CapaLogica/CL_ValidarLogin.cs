using System;
using System.Collections.Generic;
using System.Linq;
using CapaSoporte;
using CapaDatos;

namespace CapaLogica
{
    public class CL_ValidarLogin
    {
        public string Usuario { private get; set ; }
        public string Clave { private get; set; }

        public string ValidarLogin()
        {

            CD_ValidarLogin ValidaLoginCD = new CD_ValidarLogin();
            if (ValidaLoginCD.NombreUsuario(Usuario))   //valido que exista el usuario
            {
                ValidaLoginCD.CargarDatosLogin(Usuario); //cargo la capa de cache
                if (CS_UsuarioActivo.IDDirectorio == 3) return "Usuario Bloqueado"; //verifico que ya no esté bloqueado de antes
                else
                {
                    if (ValidaLoginCD.UsuarioYClave(Usuario, Clave))    //valido que exista el usuario y clave
                    {
                        return "Login Exitoso"; //valido que coincidan usuario y contraseña 
                    }
                    else
                    {
                        if (CS_UsuarioActivo.IntentosLogin < 3)
                        {
                            CS_UsuarioActivo.IntentosLogin+=1;
                            new CD_IntentosLogin(CS_UsuarioActivo.IntentosLogin, CS_UsuarioActivo.IDUsuario);
                            return $"Clave Incorrecta";
                        }
                        else
                        {
                            new CD_DirectorioUsuario(3, CS_UsuarioActivo.IDUsuario);
                            new CD_IntentosLogin(0, CS_UsuarioActivo.IDUsuario);
                            new CD_BloquearUsuario(CS_UsuarioActivo.IDUsuario);
                            return "Usuario Bloqueado";
                        }
                    }
                }
            }
            else return "Usuario Inexistente";
        }       
    }
}
