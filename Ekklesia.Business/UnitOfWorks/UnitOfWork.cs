using Ekklesia.Business.Repositories;
using Ekklesia.Data.Contexts;
using Ekklesia.Infrastructure.Interfaces.Repositories;
using Ekklesia.Infrastructure.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ekklesia.Business.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private EkklesiaContext _context;
        private IServiceProvider _serviceProvider;
        public UnitOfWork(EkklesiaContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public async ValueTask DisposeAsync(bool disposing)
        {
            await DisposeAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return (IRepository<T>)_serviceProvider.GetService(typeof(IRepository<T>));
        }

        public async Task<bool> SaveAsync()
        {
           await _context.SaveChangesAsync();
            return true;
        }
    }
}
