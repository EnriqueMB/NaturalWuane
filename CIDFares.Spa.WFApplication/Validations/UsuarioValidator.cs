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
    public class UsuarioValidator: AbstractValidator<UsuarioViewModel>
    {
        public UsuarioValidator(IUsuarioRepository usuarioService)
        {

            RuleFor(pass => pass.Password)
                .Matches(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,13}$").WithMessage("LA CONTRASEÑA DEBE TENER ENTRE 8 Y 13 CARACTERES, AL MENOS UN DÍGITO, AL MENOS UNA MINÚSCULA Y AL MENOS UNA MAYÚSCULA.")
                .When(x => x.Modificar);
               
               


            RuleFor(passdos => passdos.ContraseniaDos)
             .Must((x, value) =>
                {
                    return value.Equals("");

                }).When(x => !x.Modificar).WithMessage("DEBE INGRESAR LA CONTRASEÑA.");
             
            RuleFor(passdos => passdos.ContraseniaDos)
              .Equal((x) => x.Password)
              .WithMessage("LAS CONTRASEÑAS NO COINCIDEN.");


            RuleFor(x => x.Cuenta)
                .NotEmpty()
                .WithMessage("INGRESE CUENTA.")
                .MaximumLength(200).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 200 CARACTERES.")
                .MustAsync(async (Cuenta, x, context) =>
                 {

                     Guid result = await  usuarioService.EsCuentaUnica(Cuenta.Cuenta);
                     if (result != Guid.Empty)
                     {
                         if (result == Cuenta.IdCuentaUsuario)
                             return true;
                         else
                             return false;
                     }
                     else
                         return true;
                 })
                    .WithMessage("EL NOMBRE DE LA CUENTA YA EXISTE");

            RuleFor(x => x.IdEmpleado)
                .NotEmpty()
                .MustAsync(async (Empleado, x, context) =>
                {

                    Guid result = await usuarioService.EsCuentaEmpleadoUnico(Empleado.IdEmpleado);
                    if (result != Guid.Empty)
                    {
                        if (result == Empleado.IdEmpleado)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        return true;

                    }
                })
                    .WithMessage("EL EMPLEADO TIENE CUENTA YA EXISTEN");

            RuleFor(x => x.IdRol)
                 .NotEqual(0)
                 .WithMessage("DEBE SELECCIONAR UN ROL.");

            RuleFor(x => x.IdEmpleado)
                .NotEqual(Guid.Empty)
                .WithMessage("DEBE SELECCIONAR UN NOMBRE DE EMPLEADO.");

           




        }
    }
}
