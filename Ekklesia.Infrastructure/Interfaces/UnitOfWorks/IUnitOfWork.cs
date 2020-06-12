using Ekklesia.Infrastructure.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ekklesia.Infrastructure.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;

        Task<bool> SaveAsync();

        ValueTask DisposeAsync(bool disposing);
    }
}
