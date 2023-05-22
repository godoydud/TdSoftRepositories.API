using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TdSoftRepositories.API.Data.Context;
using TdSoftRepositories.API.Data.Repositories;

namespace TdSoftRepositories.API.CrossCutitng.DependencyInjection
{
    public class ConfigureRepositories
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CoreContext>(
                options => options.UseNpgsql(configuration.GetConnectionString("Default"))
                );

            services.AddScoped(typeof(RepositoryRepository));
            services.AddScoped(typeof(ActorsRepository));
        }
    }
}
