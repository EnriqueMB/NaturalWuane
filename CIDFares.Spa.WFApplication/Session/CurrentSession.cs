using System;

namespace CIDFares.Spa.WFApplication.Session
{
    public static class CurrentSession
    {
        public static int? IdCuentaUsuario { get; set; }

        public static int IdRol { get; set; }

        public static Guid IdEmpleado { get; set; }

        public static string Nombres { get; set; }
    }
}
