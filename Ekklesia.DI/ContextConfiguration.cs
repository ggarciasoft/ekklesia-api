using Ekklesia.Data.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ekklesia.DI
{
    public static class ContextConfiguration
    {
        public static IServiceCollection AddEkklesiaContext(this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<EkklesiaContext>(o => o.UseSqlServer(connectionString));
        }
    }
}
