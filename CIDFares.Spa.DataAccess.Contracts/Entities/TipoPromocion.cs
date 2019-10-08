using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class TipoPromocion
    {
        public int IdTipoPromocion { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
    }
}
