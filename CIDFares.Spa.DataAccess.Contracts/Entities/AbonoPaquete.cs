using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class AbonoPaquete
    {
        public Guid IdVentaPaquete { get; set; }
        public Guid IdVenta { get; set; }
        public string NombreSucursal { get; set; }
        public int Cantidad { get; set; }
        public string NombrePaquete { get; set; }
        public decimal Total { get; set; }
        public decimal Pagado { get; set; }
        public decimal Adeudo { get; set; }
        public int NPago { get; set; }
        public DateTime FechaVenta { get; set; }
        public string FolioVenta { get; set; }
        public decimal PagoPaquete { get; set; }
        public DataTable TablaPaquete { get; set; }
        public DataTable TablaFormaPago { get; set; }
        public int IdTurno { get; set; }
        public int NPagosMax { get; set; }
        public string Fecha { get; set; }
    }
}
