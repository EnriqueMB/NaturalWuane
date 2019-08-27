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
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public Guid IdTurno { get; set; }
        public Guid IdPuesto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
     
    }
}
