using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IPositionService : IService<DTO.Position, Models.Position>, IService<DTO.Position>
    {
    }
}
