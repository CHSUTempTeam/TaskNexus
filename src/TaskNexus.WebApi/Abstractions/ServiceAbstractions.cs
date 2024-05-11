using Microsoft.AspNetCore.Mvc;

namespace TaskNexus.WebApi.Abstractions {
    public interface ISessionService {
        AnswerDto GetAnswer(CancellationToken token);
    }


    public interface IIsLoginService {
        IsLoginDto GetIsLogin(CancellationToken token);
    }
    
    public interface IListProjectService {
        ListProjectDto GetList(CancellationToken token, IdDto request);
    }

    public interface ILoginService {
        AnswerDto GetAnswer(CancellationToken token, LoginDto request);
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