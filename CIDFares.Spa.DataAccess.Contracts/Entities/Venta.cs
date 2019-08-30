﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Venta
    {
        public int IdGenerico { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal SubTotal { get; set; }
        public decimal PrecioConIva { get; set; }
    }
}