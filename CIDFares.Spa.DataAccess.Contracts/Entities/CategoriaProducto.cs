using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class CategoriaProducto
    {
        public int IdCategoriaProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Resultado { get; set; }
    }
}
