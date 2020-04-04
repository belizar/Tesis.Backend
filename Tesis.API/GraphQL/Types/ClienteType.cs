using GraphQL.Types;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.API.GraphQL.Types
{
    public class ClienteType : ObjectGraphType<Cliente>
    {
        public ClienteType()
        {
            Name = "clientes";
            Field(x => x.ID, type: typeof(IdGraphType));
            Field(x => x.Nombre, type: typeof(StringGraphType));
            Field(x => x.Apellido, type: typeof(StringGraphType));
            Field(x => x.FechaDeNacimiento, type: typeof(DateGraphType));
            Field(x => x.Email, type: typeof(StringGraphType));
            Field(x => x.CUIL, type: typeof(StringGraphType));
            Field<DomicilioType>(nameof(Cliente.DomicilioPersonal));
            Field<ListGraphType<TrabajosType>>(nameof(Cliente.Trabajos));
            Field<ListGraphType<TelefonoType>>(nameof(Cliente.Telefonos));
            
        }
    }
}
