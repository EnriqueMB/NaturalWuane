using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Promocion
    {
        public Guid IdPromocion { get; set; }
        public int IdTipoPromocion { get; set; }
        public string NombrePromocion { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public int IdGenerico { get; set; }
    }
}
