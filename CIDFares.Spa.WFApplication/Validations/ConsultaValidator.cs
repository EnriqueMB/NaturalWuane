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
            RuleFor(x => x.ListaOpciones)
                .Must((x) =>{return (x.Where(y => y.Seleccionado).Count() >= 1);})
                .When(x => x.TipoPregunta == "MULTIPLE" && x.respuestasMultiples)
                .WithMessage("DEBE SELECCIONAR ALMENOS UNA OPCION.");

            RuleFor(x => x.ValueGroupRadioButton)
                .NotNull()
                .When(x => x.TipoPregunta == "MULTIPLE" && x.respuestasMultiples == false)
                .WithMessage("DEBE SELECCIONAR UNA OPCION.");

            RuleFor(x => x.RdioBtonValue)
                .NotNull()
                .When(x => x.TipoPregunta == "SI/NO")
                .WithMessage("DEBE SELECCIONAR UNA OPCION SI O NO.");

            RuleFor(x => x.Respuesta)
                .NotEmpty()
                .When(x=>x.TipoPregunta == "ABIERTA")
                .WithMessage("DEBE ESCRIBIR UNA RESPUESTA");
        }
        #endregion
    } 
}
