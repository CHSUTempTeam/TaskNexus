using Microsoft.AspNetCore.Mvc;
using TaskNexus.Web.Services;
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
        public ListProjectDto Post(CancellationToken token, IdDto id) {
            return listProjectService.GetList(token, id);
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
        public RegistrationDto Post(CancellationToken token) {
            return registrationService.GetIsLogin(token);
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
        public CreateProjectDto Post(CancellationToken token) {
            return createProjectService.GetIsLogin(token);
        }
    }
}
