using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data.Contexts
{
    public class EkklesiaContextFactory : IDesignTimeDbContextFactory<EkklesiaContext>
    {
        public EkklesiaContextFactory()
        {
        }

        public EkklesiaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EkklesiaContext>();

            optionsBuilder.UseSqlServer("EkklesiaConnection");

            return new EkklesiaContext(optionsBuilder.Options);
        }
    }
}
