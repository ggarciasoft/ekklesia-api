using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IActivityTypeService : IService<DTO.ActivityType, Models.ActivityType>, IService<DTO.ActivityType>
    {
    }
}
