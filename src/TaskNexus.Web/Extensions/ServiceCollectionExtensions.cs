using TaskNexus.Web.Services;

namespace TaskNexus.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // тут надо интерфейс регать
            services.AddSingleton<WereService>();
            services.AddSingleton<LoginService>();
            return services;
        }
    }
}
