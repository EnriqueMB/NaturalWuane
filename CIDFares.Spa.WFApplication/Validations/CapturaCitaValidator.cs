using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
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
        int hola = 0;

        public CapturaCitaValidator(ICapturaCitaRepository capturaCitaRepository)
        {
            RuleFor(cap => cap.NombreCompleto)
                .NotEmpty()
                .WithMessage("SELECCIONE UN CLIENTE.");

            RuleFor(cap => cap.Servicio)
                .NotEmpty()
                .When(x => x.IdPaquete == 0).WithMessage("SELECCIONE UN SERVICIO.");

            RuleFor(cap => cap.IdHora)
                .MustAsync(async (cap, x, context, v) =>
               {
                   var message = "";
                   var result = await capturaCitaRepository.BusyService2(cap.IdAgendaCita, cap.IdServicio, cap.FechaInicio, cap.IdSucursal);
                    //hola = result;
                    switch (result)
                   {
                       case 1:
                           message = "HORARIO OCUPADO";
                           break;
                       case 0:
                           message = "ERROR";
                           break;
                       case 5:
                           message = "NO PUEDES AGENDAR CITAS MENOR A LA HORA ACTUAL";
                           break;
                       default:
                           message = "Error default";
                           break;
                   }

                   context.MessageFormatter.AppendArgument("Message", message);

                   if (result > 0)
                   {
                       return false;
                   }
                   else
                   {
                       return true;
                   }
               })
                .WithMessage("{Message}");

            //RuleFor(cap => cap.ListaCapturaCitaDetalleServicio.Count)
            //    .Must((cap, x, context) =>
            //    {
            //        if (cap.ListaCapturaCitaDetalleServicio.Count <= 0)
            //        {

            //        }
            //        return false;
            //    }
            //  ).WithMessage("LA FECHA NO PUEDE SER MAYOR A LA FECHA ACTUAL.");

            //public string GetMessage(int mensaje)
            //{
            //    switch (mensaje)
            //    {
            //        case 1:
            //            return "HORARIO OCUPADO";
            //        case 0:
            //            return "ERROR";
            //        case 5:
            //            return "NO PUEDES AGENDAR CITAS MENOR A LA HORA ACTUAL";
            //        default:
            //            return "Error default";
            //    }
            //}
        }
    }
}