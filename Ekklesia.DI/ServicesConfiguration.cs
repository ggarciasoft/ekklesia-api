using Ekklesia.Business.Services;
using Ekklesia.Infrastructure.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.DI
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped(typeof(IService<>), typeof(CommonService<>));
        }
    }
}
