using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IService<TDTO> where TDTO : class
    {
        Task<IEnumerable<TDTO>> GetAllAsync();

        Task<TDTO> GetByIDAsync(int id);

        Task InsertAsync(TDTO entity);

        Task DeleteAsync(int id);

        Task UpdateAsync(int id, TDTO entity);
    }

    public interface IService<TDTO, TDbModel> : IService<TDTO> where TDTO : class where TDbModel : class
    {
    }
}
