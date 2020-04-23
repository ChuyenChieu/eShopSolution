using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username not empty or null");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password not empty or null").MinimumLength(7).WithMessage("Password minlengt 7 charactor");
        }
    }
}