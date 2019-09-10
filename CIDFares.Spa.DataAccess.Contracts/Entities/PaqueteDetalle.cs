using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PaqueteDetalle
    {
        public int IdDetallePaquete { get; set; }
        public int IdGenerico { get; set; }
        public int IdTipo { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precios { get; set; }
        public decimal PrecioDescuento { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal PrecioSinDescuento { get; set; }
    }
}
