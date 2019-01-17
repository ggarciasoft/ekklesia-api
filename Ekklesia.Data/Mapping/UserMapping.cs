using Ekklesia.Data.Models;
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
            builder.ToTable("Users", "Security");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.Property(o => o.Username).HasMaxLength(15).IsRequired();
            builder.Property(o => o.DisplayName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.PasswordHash).HasMaxLength(255).IsRequired();
            builder.Property(o => o.PasswordSalt).HasMaxLength(255).IsRequired();
            builder.Property(o => o.Active).IsRequired();
            builder.Property(o => o.Email).HasMaxLength(50).IsRequired();
            builder.Property(o => o.MustChangePassword).IsRequired();
            builder.Property(o => o.UserImage);
            builder.Property(o => o.InsertUserId).IsRequired();
            builder.Property(o => o.InsertDate).IsRequired();
            builder.Property(o => o.UpdateUserId);
            builder.Property(o => o.UpdateDate);

            builder.HasMany(o => o.Tenants).WithOne(o => o.User).HasForeignKey(o => o.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Role).WithMany(o => o.Users).HasForeignKey(o => o.RoleId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
