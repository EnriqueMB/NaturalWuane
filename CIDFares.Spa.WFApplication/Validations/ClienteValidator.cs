using CIDFares.Spa.Business.ViewModels.Catalogos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class ClienteValidator: AbstractValidator<ClienteViewModel>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.NombreCompleto)
            .NotEmpty()
            .WithMessage("INGRESE EL NOMBRE COMPLETO DEL CLIENTE.")
            .MaximumLength(200).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 200 CARACTERES.");

            RuleFor(x => x.Sexo)
               .NotEqual('S')
               .WithMessage("DEBE SELECCIONAR EL SEXO DEL CLIENTE.");

            RuleFor(x => x.Rfc)
               .Matches(@"^([A-ZÑ&]{3,4}) ?(?:- ?)?(\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])) ?(?:- ?)?([A-Z\d]{2})([A\d])$").WithMessage("EL REGISTRO FEDERAL DEL CONTRIBUYENTES (RFC) NO TIENE EL FORMATO CORRECTO.");

            RuleFor(x => x.Telefono)
                .NotEmpty()
                .WithMessage("INGRESE DE TELEFONO DEL CLIENTE.")
                .MaximumLength(10).WithMessage("EL NUMERO DE TELEFONO NO PUEDE SER MAYOR A 10 CARACTERES.")
                .Matches(@"^[+-]?\d+(\.\d+)?$").WithMessage("EL NUMERO DE TELEFONO NO ES VALIDO.");
            //\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})
            //RuleFor(cliente => cliente.FechaNacimiento)
            //   .Must((cliente, x, context) =>
            //   {
            //       if (cliente.FechaNacimiento.Date != DateTime.Now.Date)
            //       {
            //           DateTime date = x;
            //           if (x > DateTime.Today)
            //               return false;
            //           else
            //           {
            //               int edad = DateTime.Today.AddTicks(-date.Ticks).Year - 1;
            //               if (edad < 18)
            //                   return false;
            //               else
            //                   return true;
            //           }
            //       }
            //       else
            //           return true;
            //   }
            //   ).WithMessage("LA FECHA DE NACIMIENTO NO PUEDE SER MENOR DE 18 AÑOS ATRAS.");
        }
    }
}
