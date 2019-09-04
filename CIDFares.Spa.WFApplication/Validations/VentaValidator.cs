using CIDFares.Spa.Business.ViewModels.Ventas;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class VentaValidator : AbstractValidator<VentasViewModel>
    {
        public VentaValidator()
        {
            RuleFor(Venta => Venta.FolioCliente)
                .NotEmpty()
                .WithMessage("Seleccione un cliente");
                
        }
    }
}
