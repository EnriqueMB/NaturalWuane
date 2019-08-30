using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public int IdTipoServicio { get; set; }
        public int IdTipoIva { get; set; }  
        public string Clave { get; set; }
        public string TipoServicio { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Duracion { get; set; }
        public string Descripcion { get; set; }
        public decimal Porcentaje { get; set; }
        public string PorcentajeStr { get; set; }
        public string DescIva { get; set; }
        public bool AplicaIva { get; set; }
        public bool AplicaIEPS { get; set; }
        public bool IEPSMonto { get; set; }
        public decimal IEPS { get; set; }      
    }
}
