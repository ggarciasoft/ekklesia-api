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
    }
}
