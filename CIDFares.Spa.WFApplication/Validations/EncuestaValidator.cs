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
    public class EncuestaValidator :  AbstractValidator<EncuestasViewModel>
    {
        #region Constructor
        public EncuestaValidator()
        {
            RuleFor(x => x.NombreEncuesta)
                .NotNull()
                .NotEmpty()
                .WithMessage("INGRESE EL NOMBRE DE LA ENCUESTA.")
                .MaximumLength(80).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 80 CARACTERES.");

            RuleFor(x => x.IdTipoEncuesta)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UN TIPO DE ENCUESTA.");
        }
        #endregion
    }
}
