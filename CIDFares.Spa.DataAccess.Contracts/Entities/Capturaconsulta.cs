using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class CapturaConsulta
    {

        public CapturaConsulta()
        {
            datosCliente = new Cliente();
        }
        #region Propiedades
        public Guid IdConsulta { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTipoConsulta { get; set; }
        public Guid IdCliente { get; set; }
        public string Observaciones { get; set; }
        public string Recomendaciones { get; set; }
        public string Diagnostico { get; set; }

        public Cliente datosCliente { get; set; }
        #endregion  
    }
}
