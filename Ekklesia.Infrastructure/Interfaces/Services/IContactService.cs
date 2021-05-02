using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Infrastructure.Interfaces.Services
{
    public interface IContactService : IService<DTO.Contact, Models.Contact>, IService<DTO.Contact>
    {
    }
}
