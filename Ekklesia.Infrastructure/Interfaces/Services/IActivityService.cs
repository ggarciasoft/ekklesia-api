using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IActivityService : IService<DTO.Activity, Models.Activity>, IService<DTO.Activity>
    {
    }
}
