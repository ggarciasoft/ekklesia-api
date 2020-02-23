﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

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

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                                 .Where(t => t.GetInterfaces().Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))).ToList();

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }

            modelBuilder.Seed();
        }
    }
}
