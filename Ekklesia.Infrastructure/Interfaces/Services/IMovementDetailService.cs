using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IMovementDetailService : IService<DTO.MovementDetail, Models.MovementDetail>, IService<DTO.MovementDetail>
    {
    }
}
