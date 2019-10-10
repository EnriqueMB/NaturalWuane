using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PromocionProducto
    {
        public PromocionProducto()
        {
            Producto = new Producto();
        }
        public PromocionGeneral Promocion { get; set; }
        public Producto Producto { get; set; }
    }
}
