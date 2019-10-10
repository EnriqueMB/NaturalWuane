using CIDFares.Spa.Business.ViewModels.Catalogos;
using FluentValidation;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class DireccionesClienteValidator: AbstractValidator<DireccionesClienteViewModel>
    {
        public DireccionesClienteValidator()
        {
            RuleFor(d => d.Calle)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese la calle de la dirección");

            RuleFor(d => d.EntreCalles)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese las calles entre las que se encuentra la direccion");

            RuleFor(d => d.Referencias)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese las referencias para la dirección");

            RuleFor(d => d.Colonia)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese la colonia de la dirección");

            RuleFor(d => d.CodigoPostal)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese el codigo postal");

            RuleFor(d => d.Contacto)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese el nombre de una persona como contacto");

            RuleFor(d => d.TelefonoContacto)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("Ingrese el telefono de su contacto");

            RuleFor(d => d.NumeroInterior)
                .NotEqual(0).When(d => !d.SNInterior).WithMessage("Ingrese su numero interior");

            RuleFor(d => d.NumeroExterior)
                .NotEqual(0).When(d => !d.SNExterior).WithMessage("Ingrese su numero exterior");

            RuleFor(d => d.IdEstado)
                .NotEqual(0).WithMessage("Seleccione un estado");

            RuleFor(d => d.IdMunicipio)
                .NotEqual(0).WithMessage("Seleccione un municipio");
        }
    }
}
