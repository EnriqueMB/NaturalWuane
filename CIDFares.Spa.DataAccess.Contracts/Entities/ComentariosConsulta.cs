using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class ComentariosConsulta
    {
        public ComentariosConsulta()
        {
            dato = new CapturaConsulta();
        }

        #region Propiedades
        public Guid IdComentario { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public Guid IdUsuario { get; set; }
        public string Nombre { get; set; }

        public CapturaConsulta dato { get; set; }
        #endregion
    }
}
