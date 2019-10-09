using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    [Serializable]
    public class Cuestionario
    {
        public Cuestionario()
        {
            ListaPreguntas = new List<Preguntas>();
            ListaRespuestas = new List<Respuestas>();
        }
        #region Propiedades
        public Guid IdEncuesta { get; set; }
        public int IdTipoEncuesta { get; set; }
        public string NombreEncuesta { get; set; }
        public string Descripcion { get; set; }
        //public int IdOpcion { get; set; }
        //public int IdPregunta { get; set; }
        //public Boolean esOpcionMultiple { get; set; }       

        public List<Preguntas> ListaPreguntas { get; set; }
        public List<Respuestas> ListaRespuestas { get; set; }
        #endregion
    }
}
