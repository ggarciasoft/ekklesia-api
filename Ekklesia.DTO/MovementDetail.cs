using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.DTO
{
    public class MovementDetail
    {
        public int Id { get; set; }
        public int MovementId { get; set; }
        public int MovementTypeId { get; set; }
        public int? ContactId { get; set; }
        public int AssetId { get; set; }
        public double AssetQuantity { get; set; }
        public string Comments { get; set; }
        public virtual MovementType MovementType { get; set; }
        public virtual Movement Movement { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
