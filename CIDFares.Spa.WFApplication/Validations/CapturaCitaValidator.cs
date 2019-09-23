using CIDFares.Spa.Business.ViewModels.Ventas;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class CapturaCitaValidator : AbstractValidator<CapturaCitaViewModel>
    {
        public CapturaCitaValidator()
        {
            RuleFor(cap => cap.Cliente)
                .NotEmpty()
                .WithMessage("SELECCIONE UN CLIENTE.");

            //RuleFor(cap => cap.FechaCita)
            //    .MustAsync(async (cap, x, context) =>
            //    {
            //        //DateTime var = await generarNominaService.FechaLimite();

            //        int value = DateTime.Compare(cap.FechaCita, DateTime.Now);
            //        if (value > 0)
            //        {
            //            return true;
            //        }
            //        else if (value < 0)
            //        {
            //            return false;
            //        }
            //        else
            //            return true;
            //    })
            //    .WithMessage("LA FECHA DE LA CITA DEBE SER IGUAL O MAYOR A LA FECHA ACTUAL.");

            //RuleFor(cap => cap.HoraCita)
            //   .MustAsync(async (cap, x, context) =>
            //   {
            //        //DateTime var = await generarNominaService.FechaLimite();

            //        int value = DateTime.Compare(cap.HoraCita, DateTime.Now);
            //       if (value > 0)
            //       {
            //           return false;
            //       }
            //       else if (value < 0)
            //       {
            //           return true;
            //       }
            //       else
            //           return false;
            //   })
            //   .WithMessage("LA FECHA DE LA CITA DEBE SER IGUAL O MAYOR A LA FECHA ACTUAL.");

            //RuleFor(cat => cat.Nombre)
            //    .NotEmpty()
            //    .WithMessage("INGRESE EL NOMBRE DE LA CATEGORÍA")
            //    .MaximumLength(200).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 200 CARACTERES.")
            //    .MustAsync(async (cat, x, context) =>
            //    {
            //        int result = await categoriaProductoRepository.NameExistAsync(cat.Nombre);
            //        if (result > 0)
            //        {
            //            if (result == cat.IdCategoriaProducto)
            //                return true;
            //            else
            //                return false;
            //        }
            //        else
            //        {
            //            return true;
            //        }
            //    })
            //    .WithMessage("LA CATEGORÍA YA EXISTE");
        }
    }
}
