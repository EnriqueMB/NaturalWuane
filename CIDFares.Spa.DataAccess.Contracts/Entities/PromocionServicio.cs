using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PromocionServicio
    {
        public PromocionServicio()
        {
            Servicio = new Servicio();
        }
        public PromocionGeneral Promocion { get; set; }
        public Servicio Servicio { get; set; }
    }
}
