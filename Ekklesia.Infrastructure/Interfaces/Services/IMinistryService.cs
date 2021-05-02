using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IMinistryService : IService<DTO.Ministry, Models.Ministry>, IService<DTO.Ministry>
    {
    }
}
