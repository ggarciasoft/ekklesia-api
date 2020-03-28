using Ekklesia.Business.Repositories;
using Ekklesia.Business.UnitOfWorks;
using Ekklesia.Infrastructure.Interfaces.Repositories;
using Ekklesia.Infrastructure.Interfaces.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace Ekklesia.DI
{
    public static class UnitOfWorksConfiguration
    {
        public static IServiceCollection AddUnitOfWorks(this IServiceCollection services)
        {
            return services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
