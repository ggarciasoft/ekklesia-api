using AutoMapper;
using Ekklesia.Infrastructure.Interfaces.Repositories;
using Ekklesia.Infrastructure.Interfaces.Services;
using Ekklesia.Infrastructure.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ekklesia.Business.Services
{
    public class CommonService<TDTO, TDbModel> : IService<TDTO>, IService<TDTO, TDbModel> where TDTO : class where TDbModel : class
    {
        protected IUnitOfWork _unitOfWork;
        protected IRepository<TDbModel> _repository;
        protected IMapper _mapper;

        public CommonService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<TDbModel>();
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<TDTO>> GetAllAsync()
        {
            return ConvertIEnumerableDbModelToDTO(await _repository.GetAsync());
        }

        public async Task<TDTO> GetByIDAsync(int id)
        {
            return ConvertDbModelToDTO(await _repository.GetByIDAsync(id));
        }

        public async Task InsertAsync(TDTO entity)
        {
            await _repository.InsertAsync(ConvertDTOToDbModel(entity));
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(int id, TDTO entity)
        {
            await _repository.UpdateAsync(ConvertDTOToDbModel(entity));
            await _unitOfWork.SaveAsync();
        }

        protected TDTO ConvertDbModelToDTO(TDbModel dbModel)
        {
            return _mapper.Map<TDbModel, TDTO>(dbModel);
        }

        protected IEnumerable<TDTO> ConvertIEnumerableDbModelToDTO(IEnumerable<TDbModel> dbModel)
        {
            return _mapper.Map<IEnumerable<TDbModel>, IEnumerable<TDTO>>(dbModel);
        }

        protected TDbModel ConvertDTOToDbModel(TDTO dTO)
        {
            return _mapper.Map<TDTO, TDbModel>(dTO);
        }

        protected IEnumerable<TDbModel> ConvertIEnumerableDTOToDbModel(IEnumerable<TDTO> dTO)
        {
            return _mapper.Map<IEnumerable<TDTO>, IEnumerable<TDbModel>>(dTO);
        }
    }
}
