using GraphQL.Types;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.API.GraphQL.Types
{
    public class DomicilioType : ObjectGraphType<Domicilio>
    {
        public DomicilioType()
        {
            Name = "domicilio";
            Field(x => x.Calle, type: typeof(StringGraphType));
            Field(x => x.Numero, type: typeof(IntGraphType));
            Field(x => x.Barrio, type: typeof(StringGraphType));
            Field(x => x.Depto, type: typeof(StringGraphType));
            Field(x => x.Localidad, type: typeof(StringGraphType));
            Field(x => x.Lote, type: typeof(IntGraphType));
            Field(x => x.Piso, type: typeof(IntGraphType));
            Field(x => x.Manzana, type: typeof(IntGraphType));
        }
    }
}
