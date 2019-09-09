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
    public class EmpleadoValidator : AbstractValidator<EmpleadoViewModel>
    {
        public EmpleadoValidator(IEmpleadoRepository Servicio)
        {

            RuleFor(empleado => empleado.Nombre)
           .MustAsync(async (empleado, x, context) =>
           {

               Guid result = await Servicio.NombreCompletoExistAsync(empleado.Nombre, empleado.ApellidoPat, empleado.ApellidoMat);
               if (result != Guid.Empty)
               {
                   if (result == empleado.IdEmpleado)
                       return true;
                   else
                       return false;
               }
               else
                   return true;
           })
           .WithMessage("EL EMPLEADO CON ESTOS NOMBRES Y APELLIDOS YA SE ECNCUENTRA REGISTRADO");


            RuleFor(empleado => empleado.Clave)
            .NotEmpty()
            .WithMessage("INGRESE LA CLAVE.")
            .MaximumLength(15).WithMessage("LA CLAVE NO DEBE SER MAYOR A 15 CARACTERES.")
            .MustAsync(async (empleado, x, context) =>
            {

                Guid result = await Servicio.ClaveExistAsync(empleado.Clave);
                if (result != Guid.Empty)
                {
                    if (result == empleado.IdEmpleado)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            })
            .WithMessage("LA CLAVE YA EXISTE");

            RuleFor(Empleado => Empleado.Nombre)
               .MaximumLength(30).WithMessage("EL NOMBRE NO DEBE SER MAYOR A 30 CARACTERES.")
               .NotEmpty()
               .WithMessage("DEBE INGRESAR EL NOMBRE DEL EMPLEADO.");

            RuleFor(Empleado => Empleado.ApellidoPat)
               .MaximumLength(30).WithMessage("EL APELLIDO NO DEBE SER MAYOR A 30 CARACTERES.")
               .NotEmpty()
               .WithMessage("DEBE INGRESAR EL APELLIDO DEL ELMPLEADO.");

            RuleFor(Empleado => Empleado.ApellidoMat)
               .MaximumLength(30).WithMessage("EL APELLIDO NO DEBE SER MAYOR A 30 CARACTERES.")
               .NotEmpty()
               .WithMessage("DEBE INGRESAR EL APELLIDO DEL ELMPLEADO.");


            RuleFor(x => x.Sexo)
               .NotEqual('S')
               .WithMessage("DEBE SELECCIONAR EL SEXO DEL CLIENTE.");

            RuleFor(Empleado => Empleado.IdTurno)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UN TURNO.");


            RuleFor(Empleado => Empleado.IdPuesto)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UN PUESTO.");

            RuleFor(Empleado => Empleado.Telefono)
                .NotEmpty()
                .WithMessage("DEBE INGRESAR UN NUMERO TELEFONICO.");

            RuleFor(Empleado => Empleado.Correo)
               .NotEmpty()
               .WithMessage("DEBE INGRESAR SU DIRECCION DE CORREO ELECTRONICO.")
               .Matches("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*")
               .WithMessage("NO TIENE FORMATO DE CORREO ELECTRONICO");
            

           

            RuleFor(Empleado => Empleado.Direccion)
               .NotEmpty()
               .WithMessage("DEBE INGRESAR LA DIRECCION DEL EMPLEADO.");

            RuleFor(empleado => empleado.FechaNacimiento)
              .Must((empleado, x, context) =>
              {
                  if (empleado.FechaNacimiento.Date <= DateTime.Now.Date)
                  {
                      return true;
                  }
                  else
                      return false;
              }
              ).WithMessage("LA FECHA DE NACIMIENTO NO PUEDE SER MAYOR A LA FECHA ACTUAL.");

            RuleFor(empleado => empleado.Contraseña)
               .Matches(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,13}$")
               .WithMessage("LA CONTRASEÑA DEBE TENER ENTRE 8 Y 13 CARACTERES, AL MENOS UN DÍGITO, AL MENOS UNA MINÚSCULA Y AL MENOS UNA MAYÚSCULA.")
               .When(x => x.Modificar);


            RuleFor(empleado => empleado.Contraseña2)
                      .Equal((x) => x.Contraseña)
                      .WithMessage("LAS CONTRASEÑAS NO COINCIDEN.")
                      .When(empleado => empleado.Modificar); 

            RuleFor(empleado => empleado.Contraseña2)
                .NotEmpty()
                .WithMessage("DEBE INGRESAR UNA CONTRASEÑA")
                .When(empleado => empleado.Modificar);
        }
    }
}
