using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Business.Services
{
    public class CommonService<T> : IService<T> where T : class
    {
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entityToDelete)
        {
            throw new NotImplementedException();
        }

        public T GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
