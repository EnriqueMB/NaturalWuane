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
        int mensaje =0;
        public RegistroEntradaSalidaValidator(IRegistroEntradaSalidaRepository Servicio)
        {
            RuleFor(Registro => Registro.CodigoBarra)
           .NotEmpty().When(x => x.Codigo)
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
              .MustAsync(async (Registro, x, context) =>
              {

                  var result = await Servicio.ValidarTurno(Registro.CodigoBarra, Registro.Tipo);
                  mensaje = result;
                  if (result > 5 )//si esta mal es false
                  {
                    
                     // GetMessage();
                      return false;
                  }
                  return true;

              })
             // .WithMessage(GetMessage())
              .WithMessage("NO PUEDE HACER ESTE REGISTRO")
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
        public string GetMessage()
        {
            switch(mensaje)
            {
                case 6:
                    return "ERROR YA TE REGISTRASTE";
                case 7:
                    return "ERROR YA TE REGISTRASTE";
                case 8:
                    return "ERROR, NO PUEDES SALIR SI NO HAS ENTRADO";
                case 9:
                    return "ERROR 9";
                default:
                    return "Error default";
            }
        }

    }
}
