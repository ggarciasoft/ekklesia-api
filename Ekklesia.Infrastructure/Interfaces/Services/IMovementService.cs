using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IMovementService : IService<DTO.Movement, Models.Movement>, IService<DTO.Movement>
    {
    }
}
