using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis.API.GraphQL
{
    public class TesisSchema : Schema
    {
        public TesisSchema(IDependencyResolver resolver) : base(resolver)
        {
            this.Query = resolver.Resolve<TesisQuery>();
            
        }
    }
}
