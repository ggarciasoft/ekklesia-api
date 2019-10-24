using Ekklesia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles", "Security");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.Property(o => o.Name).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Alias).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Description).HasMaxLength(100);
            builder.Property(o => o.InsertUserId).IsRequired();
            builder.Property(o => o.InsertDate).IsRequired();
            builder.Property(o => o.IsActive).IsRequired();
            builder.Property(o => o.UpdateUserId);
            builder.Property(o => o.UpdateDate);
            builder.Property(o => o.TenantId);
        }
    }
}
