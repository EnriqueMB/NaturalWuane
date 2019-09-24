using CIDFares.Spa.Business.ViewModels.Catalogos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class ConsultaValidator : AbstractValidator<CIDcontrolViewModel>
    {
        #region Constructor
        public ConsultaValidator()
        {
            //RuleForEach(x => x.ListaOpciones).Where(x => x.Seleccionado)
            //    .NotEmpty()
            //    .WithMessage("DEBE SELECCIONAR ALMENOS UNA OPCION.");

            //RuleFor(x => x.respuestas)
            //    .NotEmpty()
            //    .WithMessage("DEBE ESCRIBIR UNA RESPUESTA");
        }
        #endregion
    }
}
