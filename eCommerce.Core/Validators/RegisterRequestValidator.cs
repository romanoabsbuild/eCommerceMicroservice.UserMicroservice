using eCommerce.Core.DTO;
using FluentValidation;

namespace eCommerce.Core.Validators
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            //EMAIL
            RuleFor(registerRequest => registerRequest.Email)
                .NotEmpty().WithMessage("Email é requerido").
                EmailAddress().WithMessage("Email com formato errado");
            // PASSWORD
            RuleFor(registerRequest => registerRequest.Password)
                .NotEmpty().WithMessage("Password é requerido");
            //PERSONAME
            RuleFor(registerRequest => registerRequest.PersonName)
                .NotEmpty().WithMessage("PersonName é requeido")
                .Length(2, 50).WithMessage("PersonName deve ser entre 2 a 50 caracteres");

            //GENDER
            RuleFor(registerRequest => registerRequest.Gender)
                .IsInEnum().WithMessage("Gender inválido");
        }
    }
}
