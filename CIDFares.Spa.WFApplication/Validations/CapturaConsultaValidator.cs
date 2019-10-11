using CIDFares.Spa.Business.ViewModels.Catalogos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class CapturaConsultaValidator : AbstractValidator<OpcionesViewModel>
    {
        #region Constructor
        public CapturaConsultaValidator()
        {
            RuleFor(x => x.Diagnostico)
                .NotEmpty()
                .WithMessage("EL CAMPO DE DIAGNOSTICO NO DEBE SER VACIO");

            RuleFor(x => x.Recomendaciones)
                .NotEmpty()
                .WithMessage("EL CAMPO DE RECOMENDACIONES NO DEBE SER VACIO");

            RuleFor(x => x.Observaciones)
                .NotEmpty()
                 .WithMessage("EL CAMPO DE OBSERVACIONES NO DEBE SER VACIO");

            //RuleFor(x => x._listaComentario)
            //    .Must((x) => { return x.Count > 0; })
            //    .WithMessage("DEBE TENER ALMENOS UN COMENTARIO");
        }
        #endregion
    }
}
