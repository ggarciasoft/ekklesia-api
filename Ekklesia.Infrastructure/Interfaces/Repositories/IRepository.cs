using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ekklesia.Infrastructure.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync(
              Expression<Func<T, bool>> filter = null,
              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
              string includeProperties = "");

        Task<T> GetByIDAsync(object id);

        Task InsertAsync(T entity);

        Task DeleteAsync(object id);

        Task DeleteAsync(T entity);

        Task UpdateAsync(T entity);
    }
}
