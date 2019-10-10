using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class DetalleProducto
    {
        #region Propiedades 
        public Guid IdVentaProducto { get; set; }
        public Guid IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }


        #endregion
    }
}
