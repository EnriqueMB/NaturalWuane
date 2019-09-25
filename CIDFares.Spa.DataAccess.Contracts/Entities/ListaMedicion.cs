using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class ListaMedicion
    {
        public int IdListaMedicion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public IEnumerable<ValorLista> DatosValor { get; set; }
        public DataTable TablaValores { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
