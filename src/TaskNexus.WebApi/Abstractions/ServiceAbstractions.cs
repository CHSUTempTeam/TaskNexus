namespace TaskNexus.WebApi.Abstractions {
    public interface ISessionService {
        AnswerDto GetAnswer(CancellationToken token);
    }


    public interface IIsLoginService {
        IsLoginDto GetIsLogin(CancellationToken token);
    }
    
    public interface IListProjectService {
        ListProjectDto GetList(CancellationToken token, SessionDto request);
    }

    public interface ILoginService {
        AnswerDto GetAnswer(CancellationToken token, LoginDto request);
    }

    public interface IOutService {
        AnswerDto GetAnswer(CancellationToken token, SessionDto request);
    }

    public interface IRenameProjectService {
        AnswerDto GetAnswer(CancellationToken token, RenameProjectDto request);
    }


    public interface IRegistrationService {
        AnswerDto GetRegistration(CancellationToken token, RegistrationDto request);
    }

    public interface IProjectService {
        ProjectDto GetIsLogin(CancellationToken token);
    }

    public interface IGetProjectService {
        GetProjectDto GetIsLogin(CancellationToken token);
    }
    
    public interface ICreateProjectService {
        AnswerDto GetAnswer(CancellationToken token, SessionDto request);
    }

    public interface IDeleteProjectService {
        AnswerDto GetAnswer(CancellationToken token, DeleteProjectDto request);
    }
    public interface IAddUserToProjectService {
        AnswerDto GetAnswer(CancellationToken token, AddUserToProjectDto request);
    }
    
}