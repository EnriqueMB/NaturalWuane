using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.DTOs.Requests
{
    public class LoginRequests
    {
        public LoginRequests()
        {
            IsValid = 0;
        }

        public int? IsValid { get; set; }

        public Guid IdCuentaUsuario { get; set; }

        public int IdRol { get; set; }

        public Guid IdEmpleado { get; set; }

        public string Nombres { get; set; }

        public int IdTurnoEmpleado { get; set; }

        public int IdSucursal { get; set; }

        public string[] ReglaUsuario { get; set; }
    }
}
