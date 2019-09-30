using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class CambioVenta
    {
        public int IdTurnoEmpleado { get; set; }
        public Guid IdEmpleado { get; set; }
        public int IdSucursal { get; set; }
        public decimal CambioTurno { get; set; }
        public int Resultado { get; set; }
    }
}
