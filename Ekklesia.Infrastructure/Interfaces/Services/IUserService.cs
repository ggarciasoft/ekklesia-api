using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IUserService : IService<DTO.User, Models.User>, IService<DTO.User>
    {
    }
}
