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
            dtoVenta = new Venta();
            dtoProducto = new BindingList<Producto>();
            dtoPaquete = new BindingList<Paquetes>();
            dtoServicio = new List<Servicio>();
        }
        public Venta dtoVenta { get; set; }
        public BindingList<Producto>  dtoProducto  { get; set; }
        public BindingList<Paquetes>  dtoPaquete { get; set; }
        public List<Servicio>  dtoServicio { get; set; }
        #endregion

        
    }
}
