using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaLogica
{
    public class CL_ValidarLogin
    {
        private string usuario, clave;
        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }

        public bool ValidarLogin()
        {
            CD_ValidarLogin validar = new CD_ValidarLogin();
            validar.Usuario = this.Usuario;
            validar.Clave = this.Clave;
            bool existe = validar.ValidarUsuario();
            return existe;
        }
    }
}
