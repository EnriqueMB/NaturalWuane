using System;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class FormaPago
    {
        public int IdFormaPago { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Resultado { get; set; }
        public Guid? IdUsuario { get; set; }

        public bool Seleccionar { get; set; }
        public decimal Cantidad { get; set; }
    }
}
