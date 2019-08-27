using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using FluentValidation;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class FormaPagoValidator : AbstractValidator<FormaPagoViewModel>
    {
        public FormaPagoValidator(IFormaPagoRepository formaPagoService)
        {
            RuleFor(FormaPago => FormaPago.Nombre)
                .NotEmpty()
                .WithMessage("INGRESE EL NOMBRE DE LA FORMA DE PAGO.")
                .MaximumLength(200).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 200 CARACTERES.")
                .MustAsync(async (FormaPago, x, context) =>
                {

                    int result = await formaPagoService.NameExistAsync(FormaPago.Nombre);
                    if (result > 0)
                    {
                        if (result == FormaPago.IdFormaPago)
                            return true;
                        else
                            return false;
                    }
                    else
                        return true;
                })
                .WithMessage("EL NOMBRE DE LA FORMA DE PAGO YA EXISTE");

            RuleFor(FormaPago => FormaPago.Descripcion)
                .MaximumLength(300).WithMessage("LA DESCRIPCIÓN NO PUEDE SER MAYOR A 300 CARACTERES.");

        }
    }
}
