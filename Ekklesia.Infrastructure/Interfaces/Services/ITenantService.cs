using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface ITenantService : IService<DTO.Tenant, Models.Tenant>, IService<DTO.Tenant>
    {
    }
}
