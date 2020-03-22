using Ekklesia.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Business.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;

        bool Save();

        void Dispose(bool disposing);
    }
}
