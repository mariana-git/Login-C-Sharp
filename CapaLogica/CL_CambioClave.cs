
using CapaDatos.Login;
using CapaSoporte;
using System.Linq;

namespace CapaLogica
{
    public class CL_CambioClave
    {
        public string NuevaClave(string clave) 
        {
            if(clave.Length >= 4 && clave.Length <= 8)
            {
                if (clave.Any(char.IsDigit))
                {
                    if (clave.Any(char.IsUpper))
                    {
                        if (clave.Any(char.IsLower))
                        {
                            //TODO cambiar clave en CD
                            CD_CambioClave cambioClave = new CD_CambioClave(clave);
                            return "Registro Exitoso";
                        }
                        else return "Falta Letra Minúscula";
                    }
                    else return "Falta Letra Mayúscula";
                }
                else return "Falta Caracter Numérico";
            }
            else return "Mínimo 4 - Máximo 8";
        }
    }
}
