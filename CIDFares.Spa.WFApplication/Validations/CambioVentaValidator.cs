using CIDFares.Spa.Business.ViewModels.Ventas;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class CambioVentaValidator: AbstractValidator<CambioVentaViewModel>
    {
        public CambioVentaValidator()
        {
            //RuleFor(Cambio => Cambio.CambioTurno)
            //    .NotEmpty()
            //    .WithMessage("ESCRIBA UNA CANTIDAD");
        }
    }
}
