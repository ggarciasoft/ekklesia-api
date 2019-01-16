using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ekklesia.Data.Models
{
    public class UserTenant
    {
        public int UserId { get; set; }
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
        public User User { get; set; }
    }
}
