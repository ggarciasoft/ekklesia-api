using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IActivityAssistantService : IService<DTO.ActivityAssistant, Models.ActivityAssistant>, IService<DTO.ActivityAssistant>
    {
    }
}
