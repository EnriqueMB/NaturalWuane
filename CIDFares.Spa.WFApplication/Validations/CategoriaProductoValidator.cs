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
                .MaximumLength(300).WithMessage("LA DESCRIPCIÓN NO PUEDE SER MAYOR A 300 CARACTERES.");
        }
    }
}
