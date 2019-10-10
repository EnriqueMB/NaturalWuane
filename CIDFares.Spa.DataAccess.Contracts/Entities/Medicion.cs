using System;
using System.Collections.Generic;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Medicion
    {        
        public int IdMedicion { get; set; }
        public string Nombre { get; set; }
        public int IdUnidaMedida { get; set; }
        public bool EsAbierta { get; set; }
        public int IdListaMedicion { get; set; }
        public Guid IdUsuario { get; set; }
        public string NombreUnidadMedida { get; set; }
        public string NombreLista { get; set; }
        public int IdValorSeleccionado { get; set; }
        public string valor { get; set; }
    }
}
