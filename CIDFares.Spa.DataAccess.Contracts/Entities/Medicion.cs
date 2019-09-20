using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Medicion
    {
        public int IdMedicion { get; set; }
        public string Nombre { get; set; }
        public int IdUnidaMedida { get; set; }
        public bool EsAbierta { get; set; }
        public int IdListaMedicion { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
