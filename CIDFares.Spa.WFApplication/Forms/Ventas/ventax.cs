using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public class ventax
    {
        public string Nombre{ get; set; }
        public decimal Precio { get; set; }
        public Button Mas { get; set; }
        public int Cantidad { get; internal set; }
        public decimal Total { get; internal set; }
    }
}
