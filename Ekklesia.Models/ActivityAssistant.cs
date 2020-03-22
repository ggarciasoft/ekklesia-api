using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Models
{
    public class ActivityAssistant
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int EntityTypeId { get; set; }
        public int? ContactId { get; set; }
        public string Comments { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual EntityType EntityType { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
