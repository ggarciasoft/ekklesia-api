using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.DTO
{
    public class Ministry
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? TenantId { get; set; }
        public int InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
