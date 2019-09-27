using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PromocionNxN
    {
        public PromocionNxN()
        {
            PromocionDias = new PromocionDias();
            Promocion = new PromocionGeneral();
        }
        public int Cantidad { get; set; }
        
        public PromocionDias PromocionDias { get; set; }

        public PromocionGeneral Promocion { get; set; }
        public int CantidadGratis { get; set; }
    }
}
