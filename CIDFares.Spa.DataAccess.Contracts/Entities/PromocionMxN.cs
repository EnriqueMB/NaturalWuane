using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class PromocionMxN
    {
        public PromocionMxN()
        {
            PromocionDias = new PromocionDias();
            Promocion = new PromocionGeneral();
        }
        public int Cantidad { get; set; }
        public int CantidadGratis { get; set; }
        public int IDGenerico { get; set; }
        public string Nombre { get; set; }
        public int IdTipo { get; set; }

        public DataTable TablaProducto { get; set; }
        public DataTable TablaServicio { get; set; }

        public PromocionDias PromocionDias { get; set; }
        public PromocionGeneral Promocion { get; set; }
    }
}
