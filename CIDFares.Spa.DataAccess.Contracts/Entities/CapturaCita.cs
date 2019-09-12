using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class CapturaCita
    {
        public Guid IdCita { get; set; }
        public Guid IdCliente { get; set; }
        public int IdEstadoCita { get; set; }
        public string NombreCompleto { get; set; }
        public string EstadoCita { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCita { get; set; }
        public string Servicio { get; set; }
    }
}
