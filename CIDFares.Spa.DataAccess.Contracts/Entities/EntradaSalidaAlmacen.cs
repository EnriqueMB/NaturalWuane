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
            TablaEntradaAlmacen = new DataTable();
            TablaSalidaAlmacen = new DataTable();
            producto = new Producto();
        }
        public string Folio { get; set; }
        public int Tipo { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public DataTable TablaEntradaAlmacen { get; set; }
        public DataTable TablaSalidaAlmacen { get; set; }

        public Producto producto { get; set; }
        public int Resultado { get; set; }
    }
}
