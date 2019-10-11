using CIDFares.Spa.Business.ViewModels.Catalogos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class ContestarMedicionValidator : AbstractValidator<ContestarMedicionViewModel>
    {

        #region Constructor
        public ContestarMedicionValidator()
        {
            //RuleFor(x => x._listaMedicion)
            //  .Must(x => x).WithMessage("No more than 10 orders are allowed")
            //  .ForEach(orderRule => {
            //      orderRule.Must(order => order.valor > 0).WithMessage("Orders must have a total of more than 0")
            //  });

            //RuleFor(x => x._listaMedicion)
            //     .MustAsync((value, x, context) =>
            //     {

            //         var result = value._listaMedicion.Where(y => y.valor != string.Empty);
            //         if (result.Count > 0)
            //         {
            //             return true;
            //         }
            //         else
            //             return true;
            //     })
            //    .WithMessage("LA CLAVE YA EXISTE");

            //RuleForEach(x => x._listaMedicion).Must()
            //{

            //})
            //.WithMessage("The list must contain fewer than 10 items");

            RuleForEach(x => x._listaMedicion)
                .Must( (item, value, context) => 
                {
                    if(value.NombreLista.Equals("Es abierta"))
                    {
                        return !(string.IsNullOrWhiteSpace(value.valor));
                    }
                    else
                    {
                        return (value.IdValorSeleccionado != 0);
                    }
                })
                .WithMessage("MENSAJE");
        }
        #endregion
    }
}
