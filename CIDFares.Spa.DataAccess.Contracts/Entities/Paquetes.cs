﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Paquetes
    {
        public Paquetes()
        {
            datoPaquete = new DetallesPaquete();
        }
        public int IdPaquete { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string NPersona { get; set; }
        public string NPago { get; set; }
        public decimal MontoPaquete { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DataTable TablaProducto { get; set; }
        public DataTable TablaServicio { get; set; }
        public int Result { get; set; }
        public List<PaqueteDetalle> ListaDetallePaquete { get; set; }
        public int CantidadServicio { get; set; }
        public int IdTipo { get; set; }
        public bool Seleccionar { get; set; }
        public decimal PagoMinimo { get; set; }
        public decimal PorcentajePago { get; set; }
        public decimal Abono { get; set; }
        public decimal PorPagar { get; set; }
        public DetallesPaquete datoPaquete { get; set; }
        public string UrlImagen { get; set; }

    }
}
