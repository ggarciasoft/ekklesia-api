using Ekklesia.Infrastructure.Interfaces.Services;
using Ekklesia.Infrastructure.Interfaces.UnitOfWorks;
using Ekklesia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Business.Services
{
    public class ActivityService : CommonService<Activity>, IActivityService
    {
        public ActivityService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Activity entity)
        {
            throw new NotImplementedException();
        }

        public Activity GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Activity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Activity entity)
        {
            throw new NotImplementedException();
        }
    }
}
