using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class DetallesPaquete
    {
        public Guid IdVentaPaquete { get; set; }
        public Guid IdVenta { get; set; }
        public Guid IdOrdenPaquete { get; set; }
        public int Cantidad{ get; set; }
        public decimal Total { get; set; }
    }
}
