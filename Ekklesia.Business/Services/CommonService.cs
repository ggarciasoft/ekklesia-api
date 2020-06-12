using Ekklesia.Infrastructure.Interfaces.Repositories;
using Ekklesia.Infrastructure.Interfaces.Services;
using Ekklesia.Infrastructure.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task DeleteAsync(object id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await _repository.DeleteAsync(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task<T> GetByIDAsync(object id)
        {
            return await _repository.GetByIDAsync(id);
        }

        public async Task InsertAsync(T entity)
        {
            await _repository.InsertAsync(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
            await _unitOfWork.SaveAsync();
        }
    }
}
