using CIDFares.Spa.Business.ViewModels.Ventas;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class CapturaCitaValidator : AbstractValidator<CapturaCitaViewModel>
    {
        public CapturaCitaValidator()
        {
            RuleFor(cap => cap.NombreCompleto)
                .NotEmpty()
                .WithMessage("SELECCIONE UN CLIENTE.");            
        }
    }
}
