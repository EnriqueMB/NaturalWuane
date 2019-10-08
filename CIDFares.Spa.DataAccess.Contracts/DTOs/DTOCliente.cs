using CIDFares.Spa.DataAccess.Contracts.Entities;
using System.Collections.Generic;

namespace CIDFares.Spa.DataAccess.Contracts.DTOs
{
    public class DTOCliente
    {
        public DTOCliente()
        {
            DatosCliente = new Cliente();
            ListaDireciones = new List<DireccionesCliente>();
        }
        public Cliente DatosCliente { get; set; }
        public List<DireccionesCliente> ListaDireciones { get; set; }
    }
}
