using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Usuario
    {
        public Guid IdCuentaUsuario { get; set; }
        public int LocalId { get; set; }
        public string Cuenta { get; set; }
        public string PasswordHash { get; set; }
        public bool Vigente { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }

        public Guid IdEmpleado { get; set; }
        public int IdUsuario { get; set; }
        public bool NuevoRegistro { get; set; }
        public int Resultado { get; set; }

    }
}
