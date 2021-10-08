using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaLogica
{
    public class CL_IntentosLogin
    {
        private string usuario;
        private int intentos = 3;


        public bool Permitidos(string usuarioIntentado)
        {
            //este método verifica que no se intente ingresar mas de tres veces con el mismo usuario y clave incorrectas, sino bloquea el usuario
            if (usuario == usuarioIntentado) 
            {

                if (intentos == 1)
                {
                    CD_BloquearUsuario CDUsuarios = new CD_BloquearUsuario();
                    CDUsuarios.Usuario = usuarioIntentado;
                    CDUsuarios.Bloquear();  //bloquear usuario
                    intentos = 3;
                    return false;
                }
                else
                {
                    intentos--;
                    return true;
                }
            }
            else
            {
                intentos--;
                usuario = usuarioIntentado;
                return true;
            }    

        }

    }
}
