using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IService<T> where T : class
    {
        T GetByID(object id);

        void Insert(T entity);

        void Delete(object id);

        void Delete(T entityToDelete);

        void Update(T entityToUpdate);
    }
}
