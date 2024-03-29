﻿using System;
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
            UnidadMedida = string.Empty;
            IdTipo = 0;
            CantidadProducto = 0;
            PorcentajePaquete = 0;
            CostoProducto = 0;
            Precio = 0;
        }

        public int IdProducto { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string NombreCategoria { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public decimal PrecioMenudeo { get; set; }
        public string UnidadMedida { get; set; }
        public int IdTipo { get; set; }
        public decimal CantidadProducto { get; set; }
        public decimal CostoProducto { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal PorcentajePaquete { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
    }
}
