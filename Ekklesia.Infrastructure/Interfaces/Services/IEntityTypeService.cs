using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IEntityTypeService : IService<DTO.EntityType, Models.EntityType>, IService<DTO.EntityType>
    {
    }
}
