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
            builder.ToTable("Tenants", "Security");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.Property(o => o.Name).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Description).HasMaxLength(100);

            builder.HasMany(o => o.Users).WithOne(o => o.Tenant).HasForeignKey(o => o.TenantId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
