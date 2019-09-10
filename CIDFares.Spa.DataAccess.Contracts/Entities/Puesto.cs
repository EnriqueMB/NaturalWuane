using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Puesto
    {
        public int IdPuesto { get; set; }
        public string NombrePuesto { get; set; }
        public string Descripcion { get; set; }
        public int Resultado { get; set; }

    }
}
