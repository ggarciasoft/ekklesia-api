using Ekklesia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class EntityTypeMapping : IEntityTypeConfiguration<EntityType>
    {
        public void Configure(EntityTypeBuilder<EntityType> builder)
        {
            builder.ToTable("EntityType", "Configuration");

            builder.Property(o => o.Name).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Alias).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Description).HasMaxLength(100);
        }
    }
}
