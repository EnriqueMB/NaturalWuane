using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            DatosRol = new Rol();
            DatosEmpleado = new Empleado();
        }
        public Rol DatosRol { get; set; }
        public Empleado DatosEmpleado { get; set; }
        public Guid IdCuentaUsuario { get; set; }
        public int LocalId { get; set; }
        public string Cuenta { get; set; }
        public string PasswordHash { get; set; }
        public string ConstraseniaDos { get; set; }
        public bool Vigente { get; set; }
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public bool NuevoRegistro { get; set; }
        public int Resultado { get; set; }
        public bool Modificar { get; set; }

    }
}
