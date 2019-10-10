using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class EntradaSalidaAlmacen
    {
        public EntradaSalidaAlmacen()
        {
            TablaEntradaSalidaAlmacen = new DataTable();
          //  producto = new Producto();
        }
        public int IdProducto { get; set; }
        public string Folio { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Motivo { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public DataTable TablaEntradaSalidaAlmacen { get; set; }

        //public Producto producto { get; set; }
        public int Resultado { get; set; }
    }
}
