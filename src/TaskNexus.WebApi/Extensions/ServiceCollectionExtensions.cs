using TaskNexus.WebApi.Services;
using TaskNexus.WebApi.Abstractions;
using TaskNexus.WebApi.DatabaseConnect;

namespace TaskNexus.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<IIsLoginService, IsLoginService>();
            services.AddScoped<IListProjectService, ListProjectService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IRegistrationService, RegistrationService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IGetProjectService, GetProjectService>();
            services.AddScoped<ICreateProjectService, CreateProjectService>();
            services.AddScoped<IOutService, OutService>();
            services.AddScoped<IRenameProjectService, RenameProjectService>();
            services.AddScoped<IDeleteProjectService, DeleteProjectService>();
            services.AddScoped<IAddUserToProjectService, AddUserToProjectService>();
            return services;
        }
    }
}
