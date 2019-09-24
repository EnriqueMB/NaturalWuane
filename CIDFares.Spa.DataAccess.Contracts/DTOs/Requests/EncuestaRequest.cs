using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.DTOs.Requests
{
    public class EncuestaRequest
    {
        #region Propiedades
        public Cuestionario dtoEncuesta { get; set; }
        public BindingList<Preguntas> dtoPreguntas { get; set; }
        public BindingList<Respuestas> dtoRespuestas { get; set; }

        #endregion    
    }
}
