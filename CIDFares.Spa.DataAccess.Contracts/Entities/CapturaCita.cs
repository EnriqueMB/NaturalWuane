using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class CapturaCita
    {
        public CapturaCita()
        {
            TablaServicio = new DataTable();
        }
        public Guid IdCita { get; set; }
        public Guid IdCliente { get; set; }
        public int IdEstadoCita { get; set; }
        public string NombreCompleto { get; set; }
        public string EstadoCita { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCita { get; set; }
        public string Servicio { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaIServicio { get; set; }
        public DateTime FechaFServicio { get; set; }        
        public DataTable TablaServicio { get; set; }

        public int Resultado { get; set; }
    }
}
