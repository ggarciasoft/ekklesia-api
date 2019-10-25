using Ekklesia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class ActivityMapping : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activity");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.Property(o => o.ActivityDate).IsRequired();
            builder.Property(o => o.ActivityTypeId).IsRequired();
            builder.Property(o => o.Comments).HasMaxLength(255).IsRequired();
            builder.Property(o => o.InsertUserId).IsRequired();
            builder.Property(o => o.InsertDate).IsRequired();
            builder.Property(o => o.UpdateUserId);
            builder.Property(o => o.UpdateDate);
        }
    }
}
