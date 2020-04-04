using GraphQL.Types;
using Tesis.API.GraphQL.Types;
using Tesis.Repositories.Definition;

namespace Tesis.API.GraphQL
{
    public class TesisQuery : ObjectGraphType
    {
        public TesisQuery(IRepositoryWrapper repository)
        {

            Field<ListGraphType<TiposDeMovimientoType>>(
                    "TiposDeMovimiento",
                    resolve: context => repository.TiposDeMovimiento.FindAll()
                );

            Field<ParametrosType>(
                "ParametrosGetActive",
                resolve: context => repository.Parametros.GetActive()
            );

            Field<ListGraphType<ParametrosType>>(
                "Parametros",
                resolve: context => repository.Parametros.FindAll()
            );


            Field<ClienteType>(
                "ClientesBy",
                arguments: new QueryArguments(new QueryArgument[] {
                    new QueryArgument(typeof(StringGraphType)) { DefaultValue = "", Name = "lastname" },
                    new QueryArgument(typeof(StringGraphType)) { DefaultValue = "", Name = "firstname" }
                    //new QueryArgument(typeof(ULongGraphType)) { DefaultValue = 0, Name = "cuil" }
                }),
                resolve: context => repository.Clientes
                                              .GetBy(context.GetArgument<string>("firstname"),
                                                       context.GetArgument<string>("lastname"),
                                                       0)
                );

              Field<ListGraphType<ClienteType>>(
                "Clientes",
                resolve: context => repository.Clientes
                                              .FindAll()
                );

            Field<ListGraphType<ClienteType>>(
                "Cliente",
                arguments: new QueryArguments(new QueryArgument[] {
                    new QueryArgument(typeof(IntGraphType)) { DefaultValue = 0, Name = "Id" }
                    }),
                resolve: context => {
                                        var id = context.GetArgument<int>("Id");
                                        return repository.Clientes
                                                  .FindByCondition(cliente => cliente.ID == id);
                                    }
                );

            Field<PageClientType>(
                "PageClient",
                arguments: new QueryArguments(new QueryArgument[] {
                    new QueryArgument(typeof(IntGraphType)) { DefaultValue = 10, Name = "limit" },
                    new QueryArgument(typeof(IntGraphType)) { DefaultValue = 0, Name = "next" }
                }),
                resolve: context => repository.Clientes
                                              .GetPage(context.GetArgument<int>("limit"),
                                                       context.GetArgument<int>("next"))
            );

            Field<PageEstadoDeCreditoType>(
                "PageEstadosDeCredito",
                arguments: new QueryArguments(new QueryArgument[] {
                    new QueryArgument(typeof(IntGraphType)) { DefaultValue = 2, Name = "limit" },
                    new QueryArgument(typeof(IntGraphType)) { DefaultValue = 0, Name = "next" }
                }),
                resolve: context => repository.EstadosDeCredito
                                              .GetPage(context.GetArgument<int>("limit"),
                                                       context.GetArgument<int>("next"))
            );

        }
    }
}
