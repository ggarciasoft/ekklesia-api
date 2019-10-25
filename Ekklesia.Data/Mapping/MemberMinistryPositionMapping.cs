using Ekklesia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    public class MemberMinistryPositionMapping : IEntityTypeConfiguration<MemberMinistryPosition>
    {
        public void Configure(EntityTypeBuilder<MemberMinistryPosition> builder)
        {
            builder.ToTable("MemberMinistryPosition");

            builder.HasKey(o => new { o.MemberId, o.MinistryId, o.PositionId });
        }
    }
}
