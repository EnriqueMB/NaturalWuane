using CIDFares.Spa.Business.ViewModels.Catalogos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class AbonoPaqueteValidator : AbstractValidator<PaqueteViewModel>
    {
        public AbonoPaqueteValidator()
        {
            RuleFor(AP => AP.PagoPaquete)
              .NotEmpty().WithMessage("INGRESE UNA CANTIDAD")
              .NotNull().WithMessage("INGRESE UNA CANTIDAD")
              .LessThanOrEqualTo(A => A.Adeudo).WithMessage("EL ABONO DEBE SER MENOR O IGUAL AL ADEUDO")
              .GreaterThan(0).WithMessage("EL PAGO DEBE SER MAYOR A 0");
        }
    }
}
