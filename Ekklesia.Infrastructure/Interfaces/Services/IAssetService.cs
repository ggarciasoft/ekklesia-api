using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IAssetService : IService<DTO.Asset, Models.Asset>, IService<DTO.Asset>
    {
    }
}
