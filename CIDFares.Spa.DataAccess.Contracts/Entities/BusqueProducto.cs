using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class BusqueProducto
    {
        public BusqueProducto()
        {
            IdProducto = 0;
            Clave = string.Empty;
            Nombre = string.Empty;
            NombreCategoria = string.Empty;
            PrecioPublico = 0;
            PrecioMayoreo = 0;
            PrecioMenudeo = 0;
        }

        public int IdProducto { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string NombreCategoria { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public decimal PrecioMenudeo { get; set; }
    }
}
