using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.DTOs
{
    public class ConsultaDto
    {
        public CapturaConsulta dtoConsulta { get; set; }
        public BindingList<OpcionCuestionario> dtoEncuestaConsulta { get; set; }
        public BindingList<OpcionMedicion> dtoMedicionesConsulta { get; set; }
        public BindingList<Respuestas> dtoEncuestaConsultaOpciones { get; set; }
        public BindingList<Respuestas> dtoRespuestaMultiple { get; set; }
        public BindingList<ComentariosConsulta> dtoComentariosConsulta { get; set; }

    }
}
