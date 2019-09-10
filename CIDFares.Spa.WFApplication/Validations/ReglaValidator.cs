using CIDFares.Spa.Business.ViewModels.Usuarios;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class ReglaValidator : AbstractValidator<ReglaPerfilViewModel>
    {
        public ReglaValidator()
        {
            RuleFor(tipo => tipo.ListaReglas)
               .Must(
               (x) =>
               {
                   return (x.Where(a => a.ReglaAsignada).Count() >= 1);
               }
               )
               .WithMessage("1");

            RuleFor(x => x.IdRol)
                .NotNull().Must(x => x > 0)
                .WithMessage("Seleccione un perfil de usuario.");
        }
    }
}
