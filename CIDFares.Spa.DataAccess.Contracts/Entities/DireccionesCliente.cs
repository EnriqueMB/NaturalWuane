using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class DireccionesCliente
    {
        public Guid IdCliente { get; set; }
        public Guid IdDireccion { get; set; }
        public string Calle { get; set; }
        public string EntreCalles { get; set; }
        public string Referencias { get; set; }
        public int NumeroInterior { get; set; }
        public int NumeroExterior { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }
        public string Contacto { get; set; }
        public string TelefonoContacto { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
