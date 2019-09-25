using CIDFares.Spa.Business.ViewModels.Catalogos;
using FluentValidation;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class ListaMedicionValidator: AbstractValidator<ListaMedicionViewModel>
    {
        public ListaMedicionValidator()
        {
            RuleFor(l => l.Nombre)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese el nombre de la lista");
        }
    }
}
