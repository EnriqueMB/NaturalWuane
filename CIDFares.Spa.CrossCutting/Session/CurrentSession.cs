﻿using System;

namespace CIDFares.Spa.CrossCutting.Session
{
    public static class CurrentSession
    {
        public static Guid IdCuentaUsuario { get; set; }

        public static int IdRol { get; set; }

        public static Guid IdEmpleado { get; set; }

        public static string Nombres { get; set; }

        public static int IdTurnoEmpleado { get; set; }
    }
}
