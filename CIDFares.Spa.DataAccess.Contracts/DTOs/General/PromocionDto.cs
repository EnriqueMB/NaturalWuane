using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.DTOs.General
{
    public class PromocionDto
    {
        public PromocionDto()
        {
            dtoPromocionProducto = new PromocionProducto();
            dtoPromocionServicio = new PromocionServicio();
        }
        public PromocionProducto dtoPromocionProducto { get; set; }
        public PromocionServicio dtoPromocionServicio { get; set; }
    }
}
