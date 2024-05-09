using TaskNexus.WebApi.Services;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IIsLoginService, IsLoginService>();
            services.AddScoped<IListProjectService, ListProjectService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IRegistrationService, RegistrationService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IGetProjectService, GetProjectService>();
            services.AddScoped<ICreateProjectService, CreateProjectService>();

            return services;
        }
    }
}
