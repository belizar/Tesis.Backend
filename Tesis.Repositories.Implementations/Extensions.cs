using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tesis.Models;

namespace Tesis.Repositories.Implementation
{
    public static class Extensions
    {
        public static void MapBase<T>(this EntityTypeBuilder<T> @this) where T : EntidadBase 
        {
            @this.HasKey(x => x.ID);
            @this.Property(x => x.Baja).HasDefaultValue(false);
        }

        public static string Spacify(this string @this)
        =>    Regex.Matches(@this, @"([A-Z][a-z]+)")
                   .Cast<Match>()
                   .Select(x => x.Value)
                   .Aggregate((a, b) => $"{a} {b}");

        public static Task<List<TSource>> ToListAsyncSafe<TSource>(this IQueryable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (!(source is IDbAsyncEnumerable<TSource>))
                return Task.FromResult(source.ToList());
            return source.ToListAsync();
        }

        public static bool OnlyActives(EntidadBase entity) => entity.Baja == false;


        public static IQueryable WhereIsNotNull<TClass>(this IQueryable<TClass> @this, Func<bool> condition, Func<TClass, bool> where) where TClass : EntidadBase
        {
            if (condition())
            {
                @this = @this.Where(where).AsQueryable();
            }

            return @this;
        }


        public static IQueryable<TClass> WhereIsNotNull<TClass>(this IOrderedQueryable<TClass> @this, Func<bool> condition, Func<TClass, bool> where) where TClass : EntidadBase
        => condition() ? @this.Where(where).AsQueryable() : @this;

    }
}
