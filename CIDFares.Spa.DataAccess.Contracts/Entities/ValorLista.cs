using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class ValorLista
    {
        public int IdValorLista { get; set; }
        public string Valor { get; set; }
        public Guid IdUsuario { get; set; }     
    }
}
