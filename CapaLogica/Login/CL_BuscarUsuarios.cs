using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using CapaDatos.Login;

namespace CapaLogica.Login
{
    public class CL_BuscarUsuarios
    {
        public DataTable Buscar(string palabra)
        {
            CD_BuscarUsuarios BuscarUsuarios = new CD_BuscarUsuarios();
            if (palabra == string.Empty)
            {
                using (DataTable DT = BuscarUsuarios.SinParametros())
                {
                    return DT;
                }
            }
            else
            {
                if (int.TryParse(palabra, out int numero))
                {
                    using (DataTable DT = BuscarUsuarios.ConParametros(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = BuscarUsuarios.ConParametros(palabra))
                    {
                        return DT;
                    }
                }                    
            }
        }
    }
}
