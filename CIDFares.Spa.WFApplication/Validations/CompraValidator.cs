using CIDFares.Spa.Business.ViewModels.Compras;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class CompraValidator : AbstractValidator<ComprasViewModel>
    {
        public CompraValidator()
        {
            RuleFor(Compra => Compra.ClaveProveedor)
                .NotEmpty()
                .WithMessage("Seleccione un proveedor");

        }

    }
}
