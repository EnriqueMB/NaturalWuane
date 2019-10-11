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
    public class PaqueteValidator : AbstractValidator<PaqueteViewModel>
    {
        public PaqueteValidator(IPaqueteRepository paqueteRepository)
        {
            RuleFor(x => x.Clave)
               .NotEmpty()
               .WithMessage("INGRESE UNA CLAVE DEL PAQUETE")
               .MaximumLength(20).WithMessage("LA CLAVE DEL PAQUETE TIENE UN MAXIMO DE 20 CARACTERES")
               .MustAsync(async (paq, x, context) =>
               {
                   int result = await paqueteRepository.NameExistAsync(paq.Clave);
                   if (result > 0)
                   {
                       if (result == paq.IdPaquete)
                           return true;
                       else
                           return false;
                   }
                   else
                       return true;
               })
               .WithMessage("LA CLAVE DEL PAQUETE YA SE ENCUENTA REGISTRADA EN LA BASE DE DATOS");

            RuleFor(x => x.Nombre)
              .NotEmpty()
              .WithMessage("INGRESE EL NOMBRE DEL PAQUETE")
              .MaximumLength(200).WithMessage("EL NOMBRE DEL PAQUETE TIENE COMO UN MÁXIMO DE 200 CARACTERES");

            RuleFor(x => x.Descripcion)
                .MaximumLength(400).WithMessage("LA DESCRIPCIÓN DEL PAQUETE TIENE COMO UN MÁXIMO DE 400 CARACTERES");
        }
    }
}
