using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tesis.Repositories.Definition
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> FindAll();
        Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        void Delete(T entity);
        Task<T> Delete(int id);

    }
}
