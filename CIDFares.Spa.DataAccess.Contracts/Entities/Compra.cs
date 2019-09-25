using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Compra
    {
        public Compra()
        {
            ProveedorCompra = new Proveedor();
            TablaProducto = new DataTable();            
        }
        public Guid IdCompra { get; set; }
        public Guid IdCompraProducto { get; set; }
        public int IdProducto { get; set; }
        public string Clave { get; set; }
        public string  Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public int IdTipoIva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal PrecioCostoConIva { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Iva { get; set; }
        public Proveedor ProveedorCompra { get; set; }
        public DataTable TablaProducto { get; set; }
        public int Resultado { get; set; }
        public string Folio { get; set; }
    }
}
