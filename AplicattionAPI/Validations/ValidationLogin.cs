using AplicattionAPI.DTOS.Request.Comand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.Validations
{
    public class ValidationLogin : AbstractValidator<LoginCommand>
    {
         public ValidationLogin()
        {
            RuleFor(x => x.Username).NotEmpty().NotNull().WithMessage("El usuario no puede ser nulo o estar vacio");
             RuleFor(c => c.Password).NotEmpty().NotNull().WithMessage("la contraseña no puede estar nula o vacio");
        }
    }

}
