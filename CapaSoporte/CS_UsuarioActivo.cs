using System;

namespace CapaSoporte
{
    public static class CS_UsuarioActivo
    {
        public static int IDUsuario { get; set; }
        public static int IDPersona { get; set; }
        public static string Usuario { get; set; }
        public static int FrecuenciaCambio { get; set; }
        public static int IDDirectorio { get; set; }

        public static int IntentosLogin { get; set; }
        public static DateTime FechaAlta { get; set; }
        public static DateTime FechaBaja { get; set; }
        public static DateTime FechaBloqueo { get; set; }
        public static DateTime FechaUltIngreso { get; set; }
        public static DateTime FechaUltCambio { get; set; }

        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Email { get; set; }
        public static int IDCargo { get; set; }
        public static string Cargo { get; set; }

        public static string ClaveNueva { get; set; }

    }
}
