using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class TipoAlimento
    {
        public int IdTipoAlimento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
