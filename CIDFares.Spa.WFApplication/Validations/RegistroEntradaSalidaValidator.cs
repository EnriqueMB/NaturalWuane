using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class RegistroEntradaSalidaValidator : AbstractValidator<RegistroEntradaSalidaViewModel>
    {
        public RegistroEntradaSalidaValidator(IRegistroEntradaSalidaRepository Servicio)
        {
            RuleFor(Registro => Registro.CodigoBarra)
           .NotEmpty()
           .WithMessage("INGRESE EL CODIGO DE BARRA.")
           .MustAsync(async (Registro, x, context) =>
            {

                Guid result = await Servicio.CodigoExista(Registro.CodigoBarra);
                if (result != Guid.Empty)
                {
                    
                        return true;
                }
                else
                    return false;
            }).When(x => x.Pass)
           .WithMessage("EL CODIGO DE BARRA NO EXISTE");

           
            RuleFor(x => x.Tipo)
               .NotEqual("S")
              .WithMessage("DEBE SELECCIONAR SI ES ENTRADA O SALIDA.")
              .MustAsync(async (Registro, x, context, y) =>
              {
                  var Mensaje = "";
                  var result = await Servicio.ValidarTurno(Registro.CodigoBarra, Registro.Tipo);
                  switch (result)
                  {
                      case 6:
                          Mensaje = "YA TE REGISTRASTE 2 VECES";
                          break;
                      case 7:
                          Mensaje = "YA TE REGISTRASTE";
                          break;
                      case 9:
                          Mensaje = "ERROR";
                          break;
                      default:
                          Mensaje = "ERROR DEFAULT";
                          break;
                  }
                  context.MessageFormatter.AppendArgument("Message", Mensaje);

                  if (result > 5 )//si esta mal es false
                  {
                      return false;
                  }
                  return true;

              })
              .WithMessage("{Message}")
              .When(x => x.Pass);

            RuleFor(Registro => Registro.Password)
          .NotEmpty()
          .WithMessage("INGRESE LA CONTRASEÑA.")
          .MustAsync(async (Registro, x, context) =>
          {

              var result = await Servicio.VerificarPassword(Registro.IdEmpleado, Registro.Password);
              if (result == 0)
              {
                  return false;
              }
              else
                  return true;
          }) .When(x => !x.Pass)
          .WithMessage("LA CONTRASEÑA NO ES CORRECTA");
        }
    }
}
