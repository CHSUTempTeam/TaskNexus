using TaskNexus.Web.Services;

namespace TaskNexus.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // тут надо интерфейс регать
            services.AddSingleton<WereService>();
            services.AddSingleton<IsLoginService>();
            services.AddSingleton<ListProjectService>();
            services.AddSingleton<LoginService>();
            services.AddSingleton<RegistrationService>();
            services.AddSingleton<ProjectService>();
            services.AddSingleton<GetProjectService>();
            services.AddSingleton<CreateProjectService>();
            return services;
        }
    }
}
