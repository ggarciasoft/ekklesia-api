using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IRoleService : IService<DTO.Role, Models.Role>, IService<DTO.Role>
    {
    }
}
