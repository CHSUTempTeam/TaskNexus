using TaskNexus.WebApi.Services;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // тут надо интерфейс регать
            services.AddScoped<IWereService, WereService>();
            return services;
        }
    }
}
