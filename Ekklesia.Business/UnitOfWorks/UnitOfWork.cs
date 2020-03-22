using Ekklesia.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Business.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {

        public void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
        }

        public bool Save()
        {
        }
    }
}
