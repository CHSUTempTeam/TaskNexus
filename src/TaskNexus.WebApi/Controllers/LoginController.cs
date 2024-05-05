using Microsoft.AspNetCore.Mvc;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
    [Route("[controller]")]
    public class ListProjectController : ControllerBase {

        private readonly ILogger<ListProjectController> _logger;
        private readonly IListProjectService listProjectService;

        public ListProjectController(ILogger<ListProjectController> logger, IListProjectService listProjectService) {
            _logger = logger;
            this.listProjectService = listProjectService;
        }

        [HttpGet(Name = "GetListProject")]
        public ListProjectDto Get(CancellationToken token) {
            return listProjectService.GetIsLogin(token);
        }
    }




    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase {

        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService loginService;

        public LoginController(ILogger<LoginController> logger, ILoginService isLoginService) {
            _logger = logger;
            this.loginService = isLoginService;
        }

        [HttpGet(Name = "GetLogin")]
        public LoginDto Get(CancellationToken token) {
            return loginService.GetIsLogin(token);
        }
    }




    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : ControllerBase {

        private readonly ILogger<RegistrationController> _logger;
        private readonly IRegistrationService registrationService;

        public RegistrationController(ILogger<RegistrationController> logger, IRegistrationService registrationService) {
            _logger = logger;
            this.registrationService = registrationService;
        }

        [HttpGet(Name = "GetRegistration")]
        public RegistrationDto Get(CancellationToken token) {
            return registrationService.GetIsLogin(token);
        }
    }


    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase {

        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectService projectService;

        public ProjectController(ILogger<ProjectController> logger, IProjectService projectService) {
            _logger = logger;
            this.projectService = projectService;
        }

        [HttpGet(Name = "GetProject")]
        public ProjectDto Get(CancellationToken token) {
            return projectService.GetIsLogin(token);
        }
    }


    [ApiController]
    [Route("[controller]")]
    public class GetProjectController : ControllerBase {

        private readonly ILogger<GetProjectController> _logger;
        private readonly IGetProjectService getProjectService;

        public GetProjectController(ILogger<GetProjectController> logger, IGetProjectService getProjectService) {
            _logger = logger;
            this.getProjectService = getProjectService;
        }

        [HttpGet(Name = "GetGetProject")]
        public GetProjectDto Get(CancellationToken token) {
            return getProjectService.GetIsLogin(token);
        }
    }


    [ApiController]
    [Route("[controller]")]
    public class CreateProjectController : ControllerBase {

        private readonly ILogger<CreateProjectController> _logger;
        private readonly ICreateProjectService createProjectService;

        public CreateProjectController(ILogger<CreateProjectController> logger, ICreateProjectService createProjectService) {
            _logger = logger;
            this.createProjectService = createProjectService;
        }

        [HttpGet(Name = "GetCreateProject")]
        public CreateProjectDto Get(CancellationToken token) {
            return createProjectService.GetIsLogin(token);
        }
    }
}
