using Microsoft.Extensions.DependencyInjection;
using TdSoftRepositories.API.Service.Services;

namespace TdSoftRepositories.API.CrossCutitng.DependencyInjection
{
    public class ConfigureService
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<RepositoryService>();
        }
    }
}
