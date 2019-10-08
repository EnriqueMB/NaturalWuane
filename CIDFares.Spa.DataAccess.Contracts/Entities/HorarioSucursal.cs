using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class HorarioSucursal
    {
        public bool Seleccionado { get; set; }
        public int Dia { get; set; }
        public string Nombre { get; set; } 
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
    }
}
