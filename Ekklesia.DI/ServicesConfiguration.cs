using Ekklesia.Business.Services;
using Ekklesia.Infrastructure.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Ekklesia.DI
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IActivityService), typeof(ActivityService));
        }
    }
}
