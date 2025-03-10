using FluentValidation;
using LoginRequest = eCommerce.Core.DTO.LoginRequest;

namespace eCommerce.Core.Validators
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            //EMAIL
            RuleFor(loginRequest => loginRequest.Email)
                .NotEmpty().WithMessage("Email é requerido")
                .EmailAddress().WithMessage("Email com formato errado");
            //PASSWORD
            RuleFor(loginRequest => loginRequest.Password).NotEmpty().WithMessage("Password é requerido");
        }
    }
}
