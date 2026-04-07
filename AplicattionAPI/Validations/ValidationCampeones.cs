using DomainAPI.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.Validations
{
    public class ValidationCampeones : AbstractValidator<Campeones>
    {
     
        public ValidationCampeones()
            {
            RuleFor(x => x.Nombre).MinimumLength(20).NotEmpty().NotNull().WithMessage("Ingresaste un nombre Nulo");
             RuleFor(c => c.Titulo).MinimumLength(20).NotEmpty().NotNull().WithMessage("Ingresaste un titulo Nulo");
             RuleFor(c => c.Region).MinimumLength(20).NotEmpty().NotNull().WithMessage("Ingresaste una region no valida");
                RuleFor(c => c.ArmaduraBase).GreaterThan(0).WithMessage("Ingresaste una armadura base menor o igual a 0");
            RuleFor(C => C.Dificultad).GreaterThan(0).LessThanOrEqualTo(10).WithMessage("Ingresaste una dificultad menor o igual a 0 o mayor a 10");
             RuleFor(c => c.RolPrincipal).IsInEnum().WithMessage("Ingresaste un rol no valido");
             RuleFor(c => c.VidaBase).GreaterThan(0).WithMessage("Ingresaste una vida base menor o igual a 0");
             RuleFor(c => c.AtaqueBase).GreaterThan(0).WithMessage("Ingresaste un ataque base menor o igual a 0");


        }

    }
}
