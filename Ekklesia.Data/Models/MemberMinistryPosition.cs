using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Models
{
    public class MemberMinistryPosition
    {
        public int MemberId { get; set; }
        public Contact Member { get; set; }
        public int MinistryId { get; set; }
        public Ministry Ministry { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
