using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PromocionDescuento
    {
        public PromocionDescuento()
        {
            PromocionDias = new PromocionDias();
            Promocion = new PromocionGeneral();
        }
        public PromocionDias PromocionDias { get; set; }

        public PromocionGeneral Promocion { get; set; }
        public bool EsMonto { get; set; }
        public decimal Descuento { get; set; }
    }
}
