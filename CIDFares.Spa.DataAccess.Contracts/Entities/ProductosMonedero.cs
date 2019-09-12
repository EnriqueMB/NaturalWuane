using System;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class ProductosMonedero
    {
        public Guid IdProductoMonedero { get; set; }
        public int IdProducto { get; set; }
        public int PuntosMonedero { get; set; }
        public bool AplicaDescuento { get; set; }
        public bool EsMonto { get; set; }
        public int PuntosDescuento { get; set; }
        public decimal Monto { get; set; }
    }
}
