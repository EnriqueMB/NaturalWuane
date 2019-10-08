using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Empleado
    {
        public Guid IdEmpleado { get; set; }
        public int LocalId { get; set; }
        public string Clave { get; set; }
        public string NombreCompleto { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public int IdTurno { get; set; }
        public string Turno { get; set; }
        public int IdPuesto { get; set; }
        public string Puesto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Contraseña { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string FotoBase64 { get; set; }
        public int Resultado { get; set; }
        public string CodigoBarra { get; set; }
        public bool UpdateFoto { get; set; }
        public bool CambiarContraseña { get; set; }


    }
}
