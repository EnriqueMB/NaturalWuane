using CIDFares.Spa.Business.ViewModels.General;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class EntradaSalidaAlmacenValidator : AbstractValidator<EntradaSalidaAlmacenViewModel>
    {
        public EntradaSalidaAlmacenValidator()
        {
            RuleFor(EntradaSalida => EntradaSalida.Fecha)
                .Must((EntradaSalida, x, context) =>
                {
                    if (EntradaSalida.Fecha.Date <= DateTime.Now.Date)
                    {
                        return true;
                    }
                    else
                        return false;
                }
              ).WithMessage("LA FECHA NO PUEDE SER MAYOR A LA FECHA ACTUAL.");

            RuleFor(EntradaSalida => EntradaSalida.Tipo)
                .NotEqual(2)
                .WithMessage("DEBES SELECCIONAR EL TIPO DE MOVIMIENTO");

            RuleFor(EntrdaSalida => EntrdaSalida.Motivo)
                .NotEmpty()
                .WithMessage("NO PUEDES DEJAR EL CAMPO VACIO");
        }
    }
}
