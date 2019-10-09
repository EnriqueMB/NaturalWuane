using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class DetalleServicio
    {
        public Guid IdVentaServicio { get; set; }
        public Guid IdVenta { get; set; }
        public int IdServicio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}
