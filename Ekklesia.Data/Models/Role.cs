using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public int? TenantId { get; set; }
        public int InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
