using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Cliente
    {
        public Guid IdCliente { get; set; }
        public int? LocalId { get; set; }
        public string Clave { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public string UrlFoto { get; set; }
        //public string Foto { get; set; }
        //public string FotoBase64 { get; set; }
        public bool UpdateFoto { get; set; }
        public string Rfc { get; set; }
        public bool NuevoRegistro { get; set; }
        public Guid IdUsuarioL { get; set; }
        public int Resultado { get; set; } 
        public int Edad { get; set; }
        public bool TieneTarjeta { get; set; }
        public int? PuntosMonedero { get; set; }
        public string Email { get; set; }
    }
}
