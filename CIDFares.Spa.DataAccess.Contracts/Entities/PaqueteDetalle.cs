using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PaqueteDetalle
    {
        public int IdGenerico { get; set; }
        public int IdTipo { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precios { get; set; }
    }
}
