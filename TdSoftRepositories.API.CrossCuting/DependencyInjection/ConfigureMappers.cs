using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TdSoftRepositories.API.Domain.DTOs;
using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.CrossCutitng.DependencyInjection
{
    public class ConfigureMappers
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<repositories, repositoriesResponseDTO>();
            }).CreateMapper());
        }
    }
}
