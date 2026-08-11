using eCommerce.Core.Entities.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.Validators
{
    public class RegisterRequestValidator :AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.");
            RuleFor(x => x.Gender)
                .IsInEnum().WithMessage("Gender is wrong.");
            RuleFor(x => x.PersonName)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name is too long.");
        }
    }
}