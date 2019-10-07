using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
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
            DatosVenta = new Venta();
            DatosSucursal = new Sucursal();
            DatosEmpleado = new Empleado();
            DatosCliente = new Cliente();
        }

        public Venta DatosVenta { get; set; }
        public Sucursal DatosSucursal { get; set; }
        public Empleado DatosEmpleado { get; set; }
        public Cliente  DatosCliente  { get; set; }
        #endregion

        
    }
}
