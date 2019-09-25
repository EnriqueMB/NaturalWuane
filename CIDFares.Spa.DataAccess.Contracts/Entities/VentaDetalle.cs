using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class VentaDetalle
    {
        public int IdGenerio { get; set; }
        public int IdTipo { get; set; }
        public string TipoVenta { get; set; }
        public string Nombre { get; set; }
        public decimal Total { get; set; }
        public int Cantidad { get; set; }
    }
}
