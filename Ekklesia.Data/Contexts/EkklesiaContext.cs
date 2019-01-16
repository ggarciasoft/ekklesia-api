using Ekklesia.Data.Mapping;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Contexts
{
    public class EkklesiaContext : DbContext
    {
        public EkklesiaContext(DbContextOptions options) : base(options)
        {
        }

        protected EkklesiaContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TenantMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new UserTenantMapping());
        }
    }
}
