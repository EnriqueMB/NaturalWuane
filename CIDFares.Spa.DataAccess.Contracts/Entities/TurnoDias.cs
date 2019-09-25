using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    class TurnoDias
    {
        public int IdTurno { get; set; }
        public string NombreTurno { get; set; }
        public string NombreDia { get; set; }
        public TimeSpan HoraEntrada1 { get; set; }
        public TimeSpan HoraSalida1 { get; set; }
    }
}
