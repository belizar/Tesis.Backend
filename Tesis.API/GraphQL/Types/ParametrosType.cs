using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;

namespace Tesis.API.GraphQL.Types
{
    public class ParametrosType : ObjectGraphType<Parametros>
    {
        public ParametrosType()
        {
            Name = "Parametros";
            Field(x => x.ID, type: typeof(IdGraphType));
            Field(x => x.TEM, type: typeof(DecimalGraphType));
            Field(x => x.TasaMora, type: typeof(DecimalGraphType));
        }
    }
}
