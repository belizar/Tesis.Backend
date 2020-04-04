using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Models;

namespace Tesis.API.GraphQL
{
    public static class Extensions
    {
        public static IQueryable WhereIsNotNull<TClass>(this IQueryable<TClass> @this, Func<bool> condition, Func<TClass, bool> where) where TClass : class
        {
            if(condition())
            {
                @this = @this.Where(where).AsQueryable();
            }

            return @this;
        }


        public static IQueryable WhereIsNotNull<TClass>(this IOrderedQueryable<TClass> @this, Func<bool> condition, Func<TClass, bool> where) where TClass : class
        {
            IEnumerable<TClass> result = null;
            if (condition())
            {
                result = @this.Where(where);
            }

            return result.AsQueryable();
        }
    }
}
