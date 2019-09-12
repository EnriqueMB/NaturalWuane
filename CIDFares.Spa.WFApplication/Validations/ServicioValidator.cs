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
    public class ServicioValidator : AbstractValidator<ServicioViewModel>
    {
        public ServicioValidator(IServicioRepository servicioRepository)
        {
            RuleFor(ser => ser.Nombre)
                .NotEmpty()
                .WithMessage("INGRESE UN SERVICIO")
                .MaximumLength(200).WithMessage("MÁXIMO 200 CARACTERES")
                .MustAsync(async (ser, x, context) =>
                {
                    int result = await servicioRepository.NameExistAsync(ser.Nombre);
                    if (result > 0)
                    {
                        if (result == ser.IdServicio)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        return true;
                    }
                })
                .WithMessage("EL SERVICIO YA EXISTE");

            RuleFor(ser => ser.IdTipoServicio)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UN TIPO DE SERVICIO");

            RuleFor(ser => ser.Clave)
                .NotEmpty()
                .WithMessage("INGRESE UNA CLAVE")
                .MaximumLength(20).WithMessage("MÁXIMO 20 CARACTERES")
                 .MustAsync(async (ser, x, context) =>
                 {
                     string result = await servicioRepository.ExisteClave(ser.Clave);
                     if (result != null)
                     {
                         if (result == ser.Clave)
                             return false;
                         else
                             return true;
                     }
                     else
                         return true;
                 })
                .WithMessage("LA CLAVE DE SERVICIO YA EXISTE");

            RuleFor(ser => ser.Precio)
                .GreaterThan(0)
                .WithMessage("INGRESE UN PRECIO VÁLIDO");

            //RuleFor(ser => ser.Duracion)
            //    .MustAsync(async (ser, x, context) =>
            //    {
            //        double result = ser.Duracion.TotalHours;
            //        //var result = Convert.ToDecimal(ser.Duracion.TotalHours);
            //        if (result <= 0.0)
            //        {                        
            //                return false;
            //        }
            //        else
            //        {
            //            return true;
            //        }
            //    })
            //    .WithMessage("LA DURACIÓN DEL SERVICIO DEBE SER MAYOR A CERO");

            RuleFor(ser => ser.IdTipoIva)
                .NotEqual(0)
                .WithMessage("SELECCIONE EL IVA");
            RuleFor(ser => ser.Descripcion)
                .NotEmpty()
                .WithMessage("INGRESE UNA DESCRIPCIÓN")
                .MaximumLength(300).WithMessage("MÁXIMO 300 CARACTERES");

            RuleFor(ser => ser.IEPS)
                .GreaterThan(0)
               .When(ser => ser.AplicaIEPS == true).WithMessage("EL IEPS DEBE SER MAYOR A CERO");                
            //.GreaterThan(0).WithMessage("EL IEPS DEBE SER MAYOR A CERO");
            //.LessThan(0).WithMessage("kol");


        }
    }
}
