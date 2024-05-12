using Microsoft.AspNetCore.Mvc;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Controllers
{
    [ApiController]
    [Route("IsLogin")]
    public class IsLoginController : ControllerBase
    {

        private readonly ILogger<IsLoginController> _logger;
        private readonly IIsLoginService isLoginService;

        public IsLoginController(ILogger<IsLoginController> logger, IIsLoginService isLoginService)
        {
            _logger = logger;
            this.isLoginService = isLoginService;
        }

        [HttpGet(Name = "GetIsLogin")]
        public IsLoginDto Get(CancellationToken token)
        {
            return isLoginService.GetIsLogin(token);
        }
    }


    [ApiController]
    [Route("GetListProject")]
    public class ListProjectController : ControllerBase {

        private readonly ILogger<ListProjectController> _logger;
        private readonly IListProjectService listProjectService;

        public ListProjectController(ILogger<ListProjectController> logger, IListProjectService listProjectService) {
            _logger = logger;
            this.listProjectService = listProjectService;
        }

        [HttpPost(Name = "GetListProject")]
        public ListProjectDto Post(CancellationToken token, [FromBody] SessionDto session) {
            return listProjectService.GetList(token, session);
        }
    }




    [ApiController]
    [Route("GetLogin")]
    public class LoginController : ControllerBase {

        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService loginService;

        public LoginController(ILogger<LoginController> logger, ILoginService isLoginService) {
            _logger = logger;
            this.loginService = isLoginService;
        }

        [HttpPost(Name = "GetLogin")]
        public AnswerDto Post(CancellationToken token,[FromBody] LoginDto loginDto) {
            return loginService.GetAnswer(token, loginDto);
        }
    }

    [ApiController]
    [Route("GetSession")]
    public class SessionController : ControllerBase {

        private readonly ILogger<LoginController> _logger;
        private readonly ISessionService sessionService;

        public SessionController(ILogger<LoginController> logger, ISessionService sessionService) {
            _logger = logger;
            this.sessionService = sessionService;
        }

        [HttpGet(Name = "GetSession")]
        public AnswerDto Get(CancellationToken token) {
            return sessionService.GetAnswer(token);
        }
    }

    [Route("GetOut")]
    public class OutController : ControllerBase {

        private readonly ILogger<LoginController> _logger;
        private readonly IOutService outService;

        public OutController(ILogger<LoginController> logger, IOutService outService) {
            _logger = logger;
            this.outService = outService;
        }

        [HttpPost(Name = "GetOut")]
        public AnswerDto Post(CancellationToken token, [FromBody] SessionDto session) {
            return outService.GetAnswer(token, session);
        }
    }

    [Route("GetRenameProject")]
    public class RenameController : ControllerBase {

        private readonly ILogger<LoginController> _logger;
        private readonly IRenameProjectService renameProjectService;

        public RenameController(ILogger<LoginController> logger, IRenameProjectService renameProjectService) {
            _logger = logger;
            this.renameProjectService = renameProjectService;
        }

        [HttpPost(Name = "GetRenameProject")]
        public AnswerDto Post(CancellationToken token, [FromBody] RenameProjectDto rename) {
            return renameProjectService.GetAnswer(token, rename);
        }
    }

    [Route("GetDeleteProject")]
    public class DeleteController : ControllerBase {

        private readonly ILogger<LoginController> _logger;
        private readonly IDeleteProjectService deleteProjectService;

        public DeleteController(ILogger<LoginController> logger, IDeleteProjectService deleteProjectService) {
            _logger = logger;
            this.deleteProjectService = deleteProjectService;
        }

        [HttpPost(Name = "GetDeleteProject")]
        public AnswerDto Post(CancellationToken token, [FromBody] DeleteProjectDto delete) {
            return deleteProjectService.GetAnswer(token, delete);
        }
    }
    

    [Route("GetAddUserToProject")]
    public class AddUserToProjectController : ControllerBase {

        private readonly ILogger<LoginController> _logger;
        private readonly IAddUserToProjectService addUserToProjectService;

        public AddUserToProjectController(ILogger<LoginController> logger, IAddUserToProjectService addUserToProjectService) {
            _logger = logger;
            this.addUserToProjectService = addUserToProjectService;
        }

        [HttpPost(Name = "GetAddUserToProject")]
        public AnswerDto Post(CancellationToken token, [FromBody] AddUserToProjectDto add) {
            return addUserToProjectService.GetAnswer(token, add);
        }
    }

    [ApiController]
    [Route("GetRegistration")]
    public class RegistrationController : ControllerBase {

        private readonly ILogger<RegistrationController> _logger;
        private readonly IRegistrationService registrationService;

        public RegistrationController(ILogger<RegistrationController> logger, IRegistrationService registrationService) {
            _logger = logger;
            this.registrationService = registrationService;
        }

        [HttpPost(Name = "GetRegistration")]
        public AnswerDto Post(CancellationToken token, [FromBody] RegistrationDto registrationDto) {
            return registrationService.GetRegistration(token, registrationDto);
        }
    }


    [ApiController]
    [Route("GetProject")]
    public class ProjectController : ControllerBase {

        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectService projectService;

        public ProjectController(ILogger<ProjectController> logger, IProjectService projectService) {
            _logger = logger;
            this.projectService = projectService;
        }

        [HttpPost(Name = "GetProject")]
        public ProjectDto Post(CancellationToken token) {
            return projectService.GetIsLogin(token);
        }
    }


    [ApiController]
    [Route("GetGetProject")]
    public class GetProjectController : ControllerBase {

        private readonly ILogger<GetProjectController> _logger;
        private readonly IGetProjectService getProjectService;

        public GetProjectController(ILogger<GetProjectController> logger, IGetProjectService getProjectService) {
            _logger = logger;
            this.getProjectService = getProjectService;
        }

        [HttpPost(Name = "GetGetProject")]
        public GetProjectDto Post(CancellationToken token) {
            return getProjectService.GetIsLogin(token);
        }
    }


    [ApiController]
    [Route("GetCreateProject")]
    public class CreateProjectController : ControllerBase {

        private readonly ILogger<CreateProjectController> _logger;
        private readonly ICreateProjectService createProjectService;

        public CreateProjectController(ILogger<CreateProjectController> logger, ICreateProjectService createProjectService) {
            _logger = logger;
            this.createProjectService = createProjectService;
        }

        [HttpPost(Name = "GetCreateProject")]
        public AnswerDto Post(CancellationToken token, [FromBody] SessionDto sessionDto) {
            return createProjectService.GetAnswer(token, sessionDto);
        }
    }
}
