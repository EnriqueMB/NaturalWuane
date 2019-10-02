using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class TurnoDias
    {
        public int IdTurno { get; set; }
        public string NombreDia { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
    }
}
