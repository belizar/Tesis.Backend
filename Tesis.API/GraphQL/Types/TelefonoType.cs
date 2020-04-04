using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Cliente;
using Tesis.Models.Dominio.Movimientos;

namespace Tesis.API.GraphQL.Types
{
    public class TelefonoType : ObjectGraphType<Telefono>
    {
        public TelefonoType()
        {
            Name = "TelefonoType";
            
            Field("ID", x => x.ID, type: typeof(IdGraphType)).Description("ID").Name("ID");
            Field("Numero", x => x.Numero, type: typeof(StringGraphType));
            Field("Descripcion", x => x.Descripcion, type: typeof(StringGraphType));
            Field("ClienteID", x => x.ClienteID, type: typeof(IntGraphType));
        }
    }
}
