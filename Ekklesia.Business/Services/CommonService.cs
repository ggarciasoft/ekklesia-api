using Ekklesia.Infrastructure.Interfaces.Repositories;
using Ekklesia.Infrastructure.Interfaces.Services;
using Ekklesia.Infrastructure.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Business.Services
{
    public class CommonService<T> : IService<T> where T : class
    {
        protected IUnitOfWork _unitOfWork;
        protected IRepository<T> _repository;
        public CommonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<T>();
        }

        public void Delete(object id)
        {
            _repository.Delete(id);
            _unitOfWork.Save();
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Save();
        }

        public T GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        public void Insert(T entity)
        {
            _repository.Insert(entity);
            _unitOfWork.Save();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Save();
        }
    }
}
