using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class PuestoValidator : AbstractValidator<PuestoViewModels>
    {
        /// <summary>
        /// Validamos el campo Nombre del puesto y se valida
        /// que dicho nombre no exista aún
        /// </summary>
        /// <param name="puestoRepository"></param>
        public PuestoValidator(IPuestoRepository puestoRepository)
        {
            RuleFor(puesto => puesto.Nombre)
                .NotEmpty().WithMessage("Ingrese el nombre del puesto.")
                .MaximumLength(50).WithMessage("El nombre del puesto excede los 50 caracteres permitido.")
                .MustAsync(async (puesto, x, context) =>
                {
                    int result = await puestoRepository.NameExistAsync(puesto.Nombre);
                    if (result > 0)
                    {
                        if (result == puesto.IdPuesto)
                            return true;
                        else
                            return false;
                    }
                    else
                        return true;
                }).WithMessage("El nombre del puesto ya existe.");

            RuleFor(puesto => puesto.Descripcion)
                .MaximumLength(100).WithMessage("La descripción del puesto excede los 100 caracteres permitido.");
                
        }
    }
}
