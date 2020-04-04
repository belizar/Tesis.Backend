using GraphQL.Types;
using Tesis.Entities;
using Tesis.Models;

namespace Tesis.API.GraphQL
{
    public abstract class PageType<T, TType> : ObjectGraphType<Page<T>> where T : EntidadBase 
                                                                        where TType : ObjectGraphType<T>
    {
        public PageType()
        {
            Field(x => x.HasNextPage, type: typeof(BooleanGraphType));
            Field(x => x.NextId, type: typeof(IntGraphType));
            Field(x => x.PreviousId, type: typeof(IntGraphType));
            Field(x => x.Data, type: typeof(ListGraphType<TType>));
        }
    }
}
