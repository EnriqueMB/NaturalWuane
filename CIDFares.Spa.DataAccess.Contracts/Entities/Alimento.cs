using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Alimento
    {
        public int IdAlimento { get; set; }
        public int IdTipoAlimento { get; set; }
        public string Nombre { get; set; }
        public string TipoAlimento { get; set; }
        public decimal Calorias { get; set; }
        public decimal HidratosCarbono { get; set; }
        public decimal Proteina { get; set; }
        public decimal Grasa { get; set; }
        public decimal Fibra { get; set; }
        public Guid? IdUsuario { get; set; }
    }
}
