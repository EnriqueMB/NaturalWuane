using CIDFares.Spa.Business.ViewModels.Ventas;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class CancelacionVentaValidator: AbstractValidator<CancelacionVentaViewModel>
    {
        public CancelacionVentaValidator()
        {
            RuleFor(cv => cv.Motivo)
               .NotEmpty()
              .WithMessage("INGRESE EL MOTIVO DE CANCELACIÓN")
              .MaximumLength(500).WithMessage("EL MOTIVO DE CANCELACIÓN TIENE COMO UN MÁXIMO DE 500 CARACTERES");
        }
    }
}
