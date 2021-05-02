using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IMovementTypeService : IService<DTO.MovementType, Models.MovementType>, IService<DTO.MovementType>
    {
    }
}
