using Ekklesia.Business.Repositories;
using Ekklesia.Infrastructure.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Ekklesia.DI
{
    public static class RepositoriesConfiguration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
