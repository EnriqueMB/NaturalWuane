using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PromocionGeneral
    {
        public int IdTipoPromocion { get; set; }
        public bool EsProducto { get; set; }
        public int IdGenerico { get; set; }
        public int Resultado { get; set; }
    }
}
