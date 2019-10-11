using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class OpcionMedicion
    {
        public OpcionMedicion()
        {
            dato = new Medicion();
        }

        public bool asignar { get; set; }
        public Medicion dato { get; set; }
    }
}
