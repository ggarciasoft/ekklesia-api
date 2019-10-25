using Ekklesia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class ActivityAssistantMapping : IEntityTypeConfiguration<ActivityAssistant>
    {
        public void Configure(EntityTypeBuilder<ActivityAssistant> builder)
        {
            builder.ToTable("ActivityAssistant");

            builder.Property(o => o.Comments).HasMaxLength(255).IsRequired();
        }
    }
}
