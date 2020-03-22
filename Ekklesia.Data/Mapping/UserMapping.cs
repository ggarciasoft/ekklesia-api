using Ekklesia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "Security");

            builder.Property(o => o.Username).HasMaxLength(15).IsRequired();
            builder.Property(o => o.DisplayName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.PasswordHash).HasMaxLength(255).IsRequired();
            builder.Property(o => o.PasswordSalt).HasMaxLength(255).IsRequired();
            builder.Property(o => o.Email).HasMaxLength(50).IsRequired();
        }
    }
}
