using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    class CategoriaProductoValidator : AbstractValidator<CategoriaProductoViewModel>
    {
        public CategoriaProductoValidator(ICategoriaProductoRepository categoriaProductoRepository)
        {
            RuleFor(cat => cat.Nombre)
                .NotEmpty()
                .WithMessage("INGRESE EL NOMBRE DE LA CATEGORÍA")
                .MaximumLength(200).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 200 CARACTERES.")
                .MustAsync(async (cat, x, context) =>
                {
                    int result = await categoriaProductoRepository.NameExistAsync(cat.Nombre);
                    if (result > 0)
                    {
                        if (result == cat.IdCategoriaProducto)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        return true;
                    }
                })
                .WithMessage("LA CATEGORÍA YA EXISTE");                           

            RuleFor(cat => cat.Descripcion)
                .MaximumLength(300).WithMessage("LA DESCRIPCIÓN NO PUEDE SER MAYOR A 300 CARACTERES.");
        }
    }
}
