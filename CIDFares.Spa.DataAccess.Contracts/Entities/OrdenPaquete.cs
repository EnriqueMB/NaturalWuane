using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class OrdenPaquete
    {
        public OrdenPaquete()
        {
            Paquete = new Paquetes();
        }
        public Guid IdOrdenPaquete { get; set; }
        public Paquetes Paquete { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
