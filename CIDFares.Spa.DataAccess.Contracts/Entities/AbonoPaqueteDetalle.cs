using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class AbonoPaqueteDetalle
    {
        public Guid IdVentaProdcuto { get; set; }
        public int NPago { get; set; }
        public int Pago { get; set; }
        public DateTime FechaPago { get; set; }
        public string Fecha { get; set; }
    }
}
