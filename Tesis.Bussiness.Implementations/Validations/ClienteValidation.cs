using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.Bussiness.Implementation.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(x => x.Apellido).NotEmpty().NotNull().WithMessage("El Apellido no puede estar vacio");
            RuleFor(x => x.FechaDeNacimiento).NotEmpty().NotNull().Must(x => x != new DateTime()).WithMessage("La fecha de nacimiento debe exisitr");
            RuleFor(x => x.Nombre).NotEmpty().NotNull().WithMessage("El Nombre no puede estar vacio");
            RuleFor(x => x.CUIL.ToString()).Length(9).WithMessage("El CUIL no es valido");
            RuleFor(x => x.Trabajos).Must(trabajos => trabajos != null && trabajos.Count > 0).WithMessage("Debe tener al menos un trabajo");
            RuleFor(x => x.Telefonos).Must(telefonos => telefonos != null && telefonos.Count > 0).WithMessage("Debe tener al menos un telefono");

            RuleFor(x => x.DomicilioPersonal).NotNull().WithMessage("El Domicilio debe existir");
            RuleFor(x => x.DomicilioPersonal.Calle).NotNull().WithMessage("La Calle debe existir");
            RuleFor(x => x.DomicilioPersonal.Barrio).NotNull().WithMessage("El Barrio debe existir");
            RuleFor(x => x.DomicilioPersonal.Localidad).NotNull().WithMessage("La Localidad debe existir");
        }
    }
}
