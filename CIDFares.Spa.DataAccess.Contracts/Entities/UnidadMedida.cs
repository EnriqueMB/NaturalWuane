using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class UnidadMedida

    {

        public UnidadMedida()
        {
            IdUnidadMedida = 0;
            Nombre = string.Empty;
        }
        public int IdUnidadMedida { get; set; }
        public string Nombre { get; set; }
    }
}
