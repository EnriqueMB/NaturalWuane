using FluentValidation;
using CIDFares.Spa.Business.ViewModels.General;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class LoginValidator: AbstractValidator<LoginViewModel>
    {
        public LoginValidator()
        {
            RuleFor(user => user.UserAccount)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("INGRESE UNA CUENTA DE USUARIO.");

            RuleFor(user => user.UserPassword)
                .Must((x, value) =>
                {
                    return !string.IsNullOrWhiteSpace(value);
                }).WithMessage("INGRESE LA CONTRASEÑA DEL USUARIO.");
        }
    }
}
