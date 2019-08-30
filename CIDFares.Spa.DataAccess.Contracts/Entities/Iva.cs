using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Iva
    {
        public int IdTipoIva { get; set; }
        public decimal Porcentaje { get; set; }
        public string Descripcion { get; set; }
        
    }
}
