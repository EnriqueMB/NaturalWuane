using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Venta
    {
        public Venta()
        {
            ClienteVenta = new Cliente();
            SucursalDatos = new Sucursal();
            TablaFormaPago = new DataTable();
            TablaProducto = new DataTable();
            TablaServicio = new DataTable();
        }
        public int IdGenerico { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal SubTotal { get; set; }
        public decimal PrecioConIva { get; set; }

        public Sucursal SucursalDatos { get; set; }
        public Cliente ClienteVenta { get; set; }
        public DataTable TablaFormaPago { get; set; }
        public DataTable TablaProducto { get; set; }
        public DataTable TablaServicio{ get; set; }
        public DataTable TablaPaquete { get; set; }

        public int Resultado { get; set; }
        public string Folio { get; set; }
        public decimal Efectivo { get; set; }
        public DateTime FechaVenta { get; set; }
        public Guid IdVenta { get; set; }
        public int LocalId { get; set; }
        public int IdTurno { get; set; }
    }
}
