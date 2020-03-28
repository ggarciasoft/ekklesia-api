using Ekklesia.Business.Repositories;
using Ekklesia.Infrastructure.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Ekklesia.DI
{
    public static class RepositoriesConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
