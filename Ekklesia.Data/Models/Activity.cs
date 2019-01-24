using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Comments { get; set; }
        public int ActivityTypeId { get; set; }
        public int? TenantId { get; set; }
        public int InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public virtual ICollection<ActivityAssistant> Assistants { get; set; }
    }
}
