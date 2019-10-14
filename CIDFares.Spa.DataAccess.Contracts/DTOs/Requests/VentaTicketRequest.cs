using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.DTOs.Requests
{
    public class VentaTicketRequest
    {
        #region Propiedades
        public VentaTicketRequest()
        {
            Venta = new Venta();
            dtoProducto = new List<Producto>();
            dtoPaquete = new List<Paquetes>();
            dtoServicio = new List<Servicio>();
        }
        public Venta Venta { get; set; }
        public List<Producto>  dtoProducto  { get; set; }
        public List<Paquetes>  dtoPaquete { get; set; }
        public List<Servicio>  dtoServicio { get; set; }
        #endregion

        
    }
}
