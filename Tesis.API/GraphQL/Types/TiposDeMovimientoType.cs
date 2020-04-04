using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Movimientos;

namespace Tesis.API.GraphQL.Types
{
    public class TiposDeMovimientoType : ObjectGraphType<TiposDeMovimiento>
    {
        public TiposDeMovimientoType()
        {
            Name = "TipoDeMovimiento";
            
            Field("ID", x => x.ID, type: typeof(IdGraphType)).Description("ID").Name("ID");
            Field("Nombre", x => x.Nombre, type: typeof(StringGraphType));
        }
    }
}
