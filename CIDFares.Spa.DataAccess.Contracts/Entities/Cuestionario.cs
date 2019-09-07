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
        #region Propiedades
        public int IdEncuesta { get; set; }
        public int IdTipoEncuesta { get; set; }
        public string NombreEncuesta { get; set; }
        public string Descripcion { get; set; }
        public int IdOpcion { get; set; }
        public int IdPregunta { get; set; }
        public Boolean esOpcionMultiple { get; set; }

        #endregion
    }
}
