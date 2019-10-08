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

            //TablaServicio = new DataTable();
            //IdHora = new TimeSpan();
            OrdenServicio = new OrdenServicio();
        }
        public Guid IdAgendaCita { get; set; }
        public OrdenServicio OrdenServicio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }

        public int Resultado { get; set; }
        public TimeSpan IdHora { get; set; }
        public string Hora { get; set; }






        //public Guid IdCita { get; set; }
        ////public Cliente IdCliente { get; set; }
        //public int IdEstadoCita { get; set; }
        //public Guid IdOrdenPaquete { get; set; }
        //public Guid IdAgendaCita { get; set; }
        ////public Guid IdOrdenServicio { get; set; }
        //public DateTime Inicio { get; set; }
        //public DateTime Fin { get; set; }
        ////public string NombreCompleto { get; set; }
        //public string Servicio { get; set; }
        //public string Paquete { get; set; }

        //public string EstadoCita { get; set; }
        //public string Observaciones { get; set; }
        //public DateTime FechaCita { get; set; }

        ////public int IdServicio { get; set; }
        //public DateTime FechaIServicio { get; set; }
        //public DateTime FechaFServicio { get; set; }
        //public DataTable TablaServicio { get; set; }


    }
}
