namespace TaskNexus.WebApi.Abstractions {

    public interface IIsLoginService {
        IsLoginDto GetIsLogin(CancellationToken token);
    }
    

    public interface IListProjectService {
        ListProjectDto GetIsLogin(CancellationToken token);
    }

    public interface ILoginService {
        LoginDto GetIsLogin(CancellationToken token);
    }

    public interface IRegistrationService {
        RegistrationDto GetIsLogin(CancellationToken token);
    }

    public interface IProjectService {
        ProjectDto GetIsLogin(CancellationToken token);
    }

    public interface IGetProjectService {
        GetProjectDto GetIsLogin(CancellationToken token);
    }
    
    public interface ICreateProjectService {
        CreateProjectDto GetIsLogin(CancellationToken token);
    }
}