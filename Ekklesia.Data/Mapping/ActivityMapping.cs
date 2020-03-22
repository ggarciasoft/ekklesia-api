using Ekklesia.Models;
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

            builder.Property(o => o.Comments).HasMaxLength(255).IsRequired();
        }
    }
}
