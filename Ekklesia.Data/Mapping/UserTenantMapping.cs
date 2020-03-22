using Ekklesia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    public class UserTenantMapping : IEntityTypeConfiguration<UserTenant>
    {
        public void Configure(EntityTypeBuilder<UserTenant> builder)
        {
            builder.ToTable("UserTenant", "Security");

            builder.HasKey(o => new { o.TenantId, o.UserId });
        }
    }
}
