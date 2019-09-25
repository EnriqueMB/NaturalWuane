using CIDFares.Spa.Business.ViewModels.Catalogos;
using FluentValidation;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class MedicionValidator: AbstractValidator<MedicionViewModel>
    {
        public MedicionValidator()
        {
            RuleFor(m => m.Nombre)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese el nombre de la medicion");

            RuleFor(m => m.IdUnidaMedida)
                .NotEqual(0)
                .WithMessage("Seleccione una unidad de medida");

            RuleFor(m => m.IdListaMedicion)
                .NotEqual(0).When(m => !m.EsAbierta)
                .WithMessage("Seleccione una lista de valores");
        }
    }
}
