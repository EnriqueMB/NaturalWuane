using CIDFares.Spa.Business.ViewModels.General;
using FluentValidation;


namespace CIDFares.Spa.WFApplication.Validations
{
    public class ProductosMonederoValidator: AbstractValidator<ProductosMonederoViewModel>
    {
        public ProductosMonederoValidator()
        {
            RuleFor(p => p.IdProducto)
                .NotEqual(0)
                .WithMessage("Debe seleccionar un producto");

            RuleFor(p => p.PuntosMonedero)
                .NotEqual(0)
                .WithMessage("Ingrese los puntos del monedero");

            RuleFor(p => p.PuntosDescuento)
                .NotEqual(0).When(p => p.AplicaDescuento)
                .WithMessage("Ingrese los puntos del descuento");

            RuleFor(p => p.Monto)
                .NotEqual(0).When(p => p.AplicaDescuento)
                .WithMessage("Ingrese el descuento");
        }
    }
}
