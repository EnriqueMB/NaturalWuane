using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public string NombreTurno { get; set; }
        public DataTable TablaValores { get; set; }
        public Guid IdUsuario { get; set; }
        public int Resultado { get; set; }
        public IEnumerable<TurnoDias> DatosValor { get; set; }
    }
}
