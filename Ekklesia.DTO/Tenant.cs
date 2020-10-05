

using System.Collections.Generic;

namespace Ekklesia.DTO
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserTenant> Users { get; set; }
    }
}