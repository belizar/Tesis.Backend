using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;

namespace Tesis.API.GraphQL.Types
{
    public class EstadoDeCreditoType : ObjectGraphType<EstadoDeCredito>
    {
        public EstadoDeCreditoType()
        {
            Name = "estadoDeCredito";
            Field(x => x.ID, type: typeof(IdGraphType));
            Field(x => x.Nombre, type: typeof(StringGraphType));
        }
    }
}
