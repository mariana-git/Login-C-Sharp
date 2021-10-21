using CapaSoporte;
using System;
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
                new CD_TraerDatosUsuario().DatosLogin(Usuario); //cargo la capa de cache el IDUsuario, Directorio y los intetos para ese nombre de usuario 
                if (CS_UsuarioActivo.IDDirectorio == 3) return "Usuario Bloqueado"; //verifico que ya no esté bloqueado de antes
                else if (CS_UsuarioActivo.IDDirectorio == 2) return "Usuario Desactivado"; //verifico que ya no esté bloqueado de antes
                else
                {
                    if (ValidaLoginCD.UsuarioYClave(Usuario, Clave))    //valido que exista el usuario y clave
                    {
                        new CD_TraerDatosUsuario().DatosUsuarioLogueado();  //cargo el resto de los datos del Usuario y la Persona en la cache
                        new CD_IntentosLogin(1, CS_UsuarioActivo.IDUsuario);     //reestablezco el contador de intentos fallidos
                        TimeSpan claveSinCambio = DateTime.Today - CS_UsuarioActivo.FechaUltCambio; //calculo la cantidad de dias entre el ultimo cambio de clave y hoy

                        if (CS_UsuarioActivo.FrecuenciaCambio > claveSinCambio.TotalDays)   //verifico que no haya expirado la contraseña
                        {
                            return "Login Exitoso";
                        }
                        else
                        {
                            return "Contraseña Expirada";
                        }                         
                    }
                    else
                    {
                        if (CS_UsuarioActivo.IntentosLogin < 3)
                        {
                            new CD_IntentosLogin(CS_UsuarioActivo.IntentosLogin+=1, CS_UsuarioActivo.IDUsuario);
                            return $"Clave Incorrecta";
                        }
                        else
                        {
                            new CD_DirectorioUsuario(3, CS_UsuarioActivo.IDUsuario);
                            new CD_IntentosLogin(1, CS_UsuarioActivo.IDUsuario);
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
