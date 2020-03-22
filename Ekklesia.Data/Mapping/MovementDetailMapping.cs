using Ekklesia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Mapping
{
    internal class MovementDetailMapping : IEntityTypeConfiguration<MovementDetail>
    {
        public void Configure(EntityTypeBuilder<MovementDetail> builder)
        {
            builder.ToTable("MovementDetail");

            builder.Property(o => o.Comments).HasMaxLength(255).IsRequired();
        }
    }
}
