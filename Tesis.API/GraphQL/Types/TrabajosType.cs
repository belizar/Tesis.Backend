using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.API.GraphQL.Types
{
    public class TrabajosType : ObjectGraphType<Trabajo>
    {
        public TrabajosType()
        {
            Name = "trabajo";
            Field(x => x.ID, type: typeof(IdGraphType));
            Field(x => x.ClienteID, type: typeof(IntGraphType));
            Field(x => x.Cargo, type: typeof(StringGraphType));
            Field(x => x.LugarDeTrabajo, type: typeof(StringGraphType));
            Field(x => x.FechaDeIngreso, type: typeof(DateGraphType));
            Field(x => x.TelefonoLaboral, type: typeof(StringGraphType));

            Field<ClienteType>(nameof(Trabajo.Cliente));
            Field<DomicilioType>(nameof(Trabajo.DomicilioLaboral));
        }
    }
}
