using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.DTOs.Requests
{
    public class DireccionesClienteRequest
    {
        public DireccionesClienteRequest()
        {
            DatosEstado = new Estado();
            DatosMunicipio = new Municipio();
        }
        
        public Guid IdCliente { get; set; }
        public Guid IdDireccion { get; set; }
        public string Calle { get; set; }
        public string EntreCalles { get; set; }
        public string Referencias { get; set; }
        public int NumeroInterior { get; set; }
        public int NumeroExterior { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public Estado DatosEstado { get; set; }
        public Municipio DatosMunicipio { get; set; }
        public string Contacto { get; set; }
        public string TelefonoContacto { get; set; }
    }
}
