using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using FluentValidation;
using System;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class AlimentoValidator: AbstractValidator<AlimentoViewModels>
    {
        public AlimentoValidator(IAlimentoRepository alimentoRepository)
        {
            RuleFor(alimento => alimento.Nombre)
                .NotEmpty().WithMessage("INGRESE UN NOMBRE")
                .MaximumLength(50).WithMessage("EL NOMBRE EXCEDE EL NÚMERO DE CARACTERES PERMITIDO")
                .MustAsync(async (alimento, x, context) =>
                {
                    var result = await alimentoRepository.NameExistAsync(alimento.Nombre);
                    if(result > 0)
                    {
                        if (result == alimento.IdAlimento)
                            return true;
                        else
                            return false;
                    }
                    return true;
                }).WithMessage("EL NOMBRE YA EXISTE");

            RuleFor(alimento => alimento.IdTipoAlimento)
                .NotEqual(0).WithMessage("DEBE SELECCIONAR UN GRUPO ALIMENTICIO");

            //RuleFor(alimento => alimento.Calorias)
            //    .NotEmpty().WithMessage("LAS CALORIAS NO PUEDEN SER VACIAS");

            //RuleFor(alimento => alimento.HidratosCarbono)
            //  .NotEmpty().WithMessage("LOS HIDRATOS DE CARBONO NO PUEDEN SER VACIAS");

            //RuleFor(alimento => alimento.Proteina)
            //    .NotEmpty().WithMessage("LAS PROTEÍNAS NO PUEDEN SER VACIAS");

            //RuleFor(alimento => alimento.Grasa)
            //    .NotEmpty().WithMessage("LAS GRASAS NO PUEDEN SER VACIAS");

            //RuleFor(alimento => alimento.Fibra)
            //    .NotEmpty().WithMessage("LAS FIBRAS NO PUEDEN SER VACIAS");


        }
    }
}
