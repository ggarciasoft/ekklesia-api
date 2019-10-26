using Ekklesia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class MinistryMapping : IEntityTypeConfiguration<Ministry>
    {
        public void Configure(EntityTypeBuilder<Ministry> builder)
        {
            builder.ToTable("Ministry", "Configuration");

            builder.Property(o => o.Name).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Alias).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Description).HasMaxLength(100);
        }
    }
}
