using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Models
{
    public class Movement
    {
        public int Id { get; set; }
        public DateTime MovementDate { get; set; }
        public string Comments { get; set; }
        public int? ActivityId { get; set; }
        public int TenantId { get; set; }
        public int InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
