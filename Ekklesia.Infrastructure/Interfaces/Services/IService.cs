using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIDAsync(object id);

        Task InsertAsync(T entity);

        Task DeleteAsync(object id);

        Task DeleteAsync(T entity);

        Task UpdateAsync(T entity);
    }
}
