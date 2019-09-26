using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    class TurnoDiasInter
    {
        public int IdTurno { get; set; }
        public string NombreDia { get; set; }
        public TimeSpan HoraEntrada1 { get; set; }
        public TimeSpan HoraSalida1 { get; set; }
        public TimeSpan HoraEntrada2 { get; set; }
        public TimeSpan HoraSalida2 { get; set; }
    }
}
