using Ekklesia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            builder.Property(o => o.FirstName).HasMaxLength(15).IsRequired();
            builder.Property(o => o.LastName).HasMaxLength(15).IsRequired();
            builder.Property(o => o.Address).HasMaxLength(255);
            builder.Property(o => o.CellPhone).HasMaxLength(30);
            builder.Property(o => o.HomePhone).HasMaxLength(30);
            builder.Property(o => o.ContactImage).HasMaxLength(255);
            builder.Property(o => o.Email).HasMaxLength(50).IsRequired();
        }
    }
}
