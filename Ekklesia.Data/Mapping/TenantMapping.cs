using Ekklesia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class TenantMapping : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.ToTable("Tenant", "Security");

            builder.Property(o => o.Name).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Description).HasMaxLength(100);
        }
    }
}
