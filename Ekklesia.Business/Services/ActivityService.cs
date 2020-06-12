using Ekklesia.Infrastructure.Interfaces.Services;
using Ekklesia.Infrastructure.Interfaces.UnitOfWorks;
using Ekklesia.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ekklesia.Business.Services
{
    public class ActivityService : CommonService<Activity>, IActivityService
    {
        public ActivityService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task DeleteAsync(object id)
        {
           await base.DeleteAsync(id);
        }

        public async Task DeleteAsync(Activity entity)
        {
           await base.DeleteAsync(entity);
        }

        public async Task<Activity> GetByIDAsync(object id)
        {
           return await base.GetByIDAsync(id);
        }

        public async Task InsertAsync(Activity entity)
        {
           await base.InsertAsync(entity);
        }

        public async Task UpdateAsync(Activity entity)
        {
           await base.InsertAsync(entity);
        }
    }
}
