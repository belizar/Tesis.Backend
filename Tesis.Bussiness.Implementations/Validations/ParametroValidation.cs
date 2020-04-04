using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Bussiness.Implementation.Validations
{
    public class ParametroValidation : AbstractValidator<Parametros>
    {
        public ParametroValidation()
        {
            RuleFor(x => x.TasaMora).GreaterThan(0).WithMessage("La tasa de mora debe ser mayor a cero");
            RuleFor(x => x.TEM).GreaterThan(0).WithMessage("El TEM debe ser mayor a cero");
        }
    }
}
