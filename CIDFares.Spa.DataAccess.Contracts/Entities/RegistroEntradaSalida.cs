using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class RegistroEntradaSalida
    {
        public Guid IdEmpleado { get; set; }
        public string Tipo { get; set; }
        public string CodigoBarra { get; set; }
        public string Password { get; set; }
    }
}
