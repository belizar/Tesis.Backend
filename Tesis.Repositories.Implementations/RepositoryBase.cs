using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Tesis.Entities;
using Tesis.Models;
using Tesis.Repositories.Definition;
using Tesis.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

namespace Tesis.Repositories.Implementation
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntidadBase
    {
        private readonly AlimaDataContext context;

        public RepositoryBase(AlimaDataContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await CustomFindAll(this.context.Set<T>()).ToListAsyncSafe();
        }

        public virtual IQueryable<T> CustomFindAll(Microsoft.EntityFrameworkCore.DbSet<T> set)
        {
            return set.AsQueryable();
        }

        public async Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return await CustomFindAll(this.context.Set<T>())
                             .Where(expression)
                             .ToListAsyncSafe();
        }

        public async Task Create(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
        }

        public async Task Update(T entity)
        {
            this.context.Set<T>().Attach(entity);
            await this.context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public async Task<T> Delete(int id)
        {
            var entity = (T) await this.context.FindAsync(typeof(T), new object[] { id });
            entity.Baja = true;
            this.context.Set<T>().Update(entity);

            return await Task.FromResult(entity);
        }

        protected async Task<Page<T>> GetPage(Microsoft.EntityFrameworkCore.DbSet<T> dbset, int take, int skip)
        {

            var page = new Page<T>();

            var query = dbset.OrderBy(x => x.ID)
                             .Skip(skip)
                             .Take(take);

            page.Total = await dbset.CountAsyncSafe();

            page.Data = await query.ToListAsyncSafe();

            if (page.Data.Count() == take)
            {
                page.HasNextPage = true;
            }

            return await Task.FromResult(page);
        }

    }
}
