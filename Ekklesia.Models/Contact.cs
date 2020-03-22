using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public bool IsLocalMember { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? ConversionDate { get; set; }
        public DateTime? BaptismDate { get; set; }
        public byte[] ContactImage { get; set; }
        public bool IsActive { get; set; }
        public int TenantId { get; set; }
        public int InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<MemberMinistryPosition> MinistriesPositions { get; set; }
    }
}
