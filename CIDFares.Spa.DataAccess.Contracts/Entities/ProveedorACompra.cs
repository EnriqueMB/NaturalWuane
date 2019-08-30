using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class ProveedorACompra
    {
        public Guid IdProveedor { get; set; }
        public string Clave { get; set; }
        public string NombreComercial { get; set; }
        public string RazonSocial { get; set; }
        public string Representante { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string NombreProvedor { get; set; }

        public Guid IdProveedorTemp { get; set; }
        
    }
}
