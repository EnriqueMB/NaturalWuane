using System;
using System.Linq;

namespace CIDFares.Spa.WFApplication.Session
{
    public static class CurrentSession
    {
        public static Guid IdCuentaUsuario { get; set; }

        public static int IdRol { get; set; }

        public static Guid IdEmpleado { get; set; }

        public static string Nombres { get; set; }

        public static int IdTurnoEmpleado { get; set; }

        public static int IdSucursal { get; set; }

        //Permisos de usuario
        public static string[] ReglasUsuario { get; set; }

        public static bool PermisoUsuario(string ValidarReglas)
        {
            string[] ReglaVerificar = ValidarReglas.Split(',');
            foreach (var item in ReglaVerificar)
            {
                if (item != "" && ReglasUsuario.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
