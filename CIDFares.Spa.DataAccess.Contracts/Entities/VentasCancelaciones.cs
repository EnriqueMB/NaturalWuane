using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class VentasCancelaciones
    {
        public Guid IdCancelacionVenta { get; set; }
        public Guid IdVenta { get; set; }
        public int LocalId { get; set; }
        public string MotivoCancelacion { get; set; }
        public int Resultado { get; set; }
        public List<VentaDetalle> ListaVentaDetalle { get; set; }
    }
}
