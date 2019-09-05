using FluentValidation;
using CIDFares.Spa.Business.ViewModels.General;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class SucursalValidator : AbstractValidator<SucursalViewModel>
    {
        public SucursalValidator() {
            RuleFor(sucursal => sucursal.Nombre)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("INGRESE EL NOMBRE DE LA SUCURSAL")
                .MaximumLength(30).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 30 CARACTERES");
                

            RuleFor(sucursal => sucursal.Direccion)
              .Must((x, value) =>
              {
                  return !string.IsNullOrWhiteSpace(value);
              }).WithMessage("INGRESE LA DIRECCION DE LA SUCURSAL")
                .MaximumLength(300).WithMessage("LA DIRECCION NO PUEDE SER MAYOR A 30 CARACTERES");

            RuleFor(sucursal => sucursal.Telefono)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("INGRESE EL NUMERO DE TELEFONO")
                .Must((x, value) =>
                {
                    return value.Length.Equals(10);
                }).WithMessage("EL NUMERO DE TELEFONO TIENE QUE SER DE 10 CARACTERES");

            RuleFor(sucursal => sucursal.CodigoPostal)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("INGRESE EL CODIGO POSTAL");

            RuleFor(sucurasl => sucurasl.Rfc)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("INGRESE EL RFC DE LA SUCURSAL");

            RuleFor(sucusarl => sucusarl.NombreRepresentante)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("INGRESE EL NOMBRE DEL REPRESENTANTE");

            RuleFor(sucusarl => sucusarl.RegimenFiscal)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("INGRESE EL REGIMEN FISCAL");

            RuleFor(sucursal => sucursal.IdPais)
                .NotEqual(0).WithMessage("DEBE SELECCIONAR UN PAIS");

            RuleFor(sucursal => sucursal.IdEstado)
                .NotEqual(0).WithMessage("DEBE SELECCIONAR UN ESTADO");

            RuleFor(sucursal => sucursal.IdMunicipio)
                .NotEqual(0).WithMessage("DEBE SELECCIONAR UN MUNICIPIO");

            RuleFor(sucursal => sucursal.IdTipoSucursal)
                .NotEqual(0).WithMessage("DEBE SELECCIONAR UN TIPO DE SUCURSAL");
        }
    }
}

