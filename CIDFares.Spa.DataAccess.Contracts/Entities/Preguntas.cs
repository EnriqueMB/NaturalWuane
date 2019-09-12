using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Preguntas
    {
        public Preguntas()
        {
            Respuesta = new List<Respuestas>();
        }

        public Guid IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public string TipoPregunta { get; set; }
        public Guid IdPreguntaDepende { get; set; }
        public string DependePregunta { get; set; }
        public int Orden { get; set; }
        public List<Respuestas> Respuesta { get; set; }
    }
}
