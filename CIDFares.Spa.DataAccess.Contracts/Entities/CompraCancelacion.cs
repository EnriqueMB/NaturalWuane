using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class CompraCancelacion
    {
        public Guid IdCancelacionCompra{ get; set; }
        public Guid IdCompra { get; set; }
        public string Motivo { get; set; }
    }
}
