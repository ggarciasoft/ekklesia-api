using Ekklesia.Business.Repositories;
using Ekklesia.Data.Contexts;
using Ekklesia.Infrastructure.Interfaces.Repositories;
using Ekklesia.Infrastructure.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

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


        public void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return (IRepository<T>)_serviceProvider.GetService(typeof(IRepository<T>));
        }

        public bool Save()
        {
           _context.SaveChanges();
            return true;
        }
    }
}
