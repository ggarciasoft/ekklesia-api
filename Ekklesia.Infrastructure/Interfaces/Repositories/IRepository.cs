﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ekklesia.Infrastructure.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get(
              Expression<Func<T, bool>> filter = null,
              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
              string includeProperties = "");

        T GetByID(object id);

        void Insert(T entity);

        void Delete(object id);

        void Delete(T entity);

        void Update(T entity);
    }
}
