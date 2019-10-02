using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PromocionGeneral
    {
        public PromocionGeneral()
        {
            TipoPromocion = new TipoPromocion();
        }
        
        public Guid IdPromocion { get; set; }
        public TipoPromocion TipoPromocion { get; set; }

        public int Cantidad { get; set; }
        public int Limite { get; set; }
        public string NombrePromocion { get; set; }
        public bool Estatus { get; set; }

        public bool EsProducto { get; set; }
        public int IdGenerico { get; set; }
        public int Resultado { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
    }
}
