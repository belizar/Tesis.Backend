using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Bussiness.Implementation.Validations
{
    public class CreditoValidation : AbstractValidator<Credito>
    {
        public CreditoValidation()
        {

        }
    }
}
