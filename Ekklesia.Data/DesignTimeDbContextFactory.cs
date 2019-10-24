using Ekklesia.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ekklesia.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EkklesiaContext>
    {
        public EkklesiaContext CreateDbContext(string[] args)
        {
            // Get environment
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // Build config
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Ekklesia.API"))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            // Get connection string
            var optionsBuilder = new DbContextOptionsBuilder<EkklesiaContext>();
            var connectionString = config.GetConnectionString(nameof(EkklesiaContext));
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("Ekklesia.Data"));
            return new EkklesiaContext(optionsBuilder.Options);
        }
    }
}
