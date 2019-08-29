using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public string Descripcion { get; set; }
    }
}
