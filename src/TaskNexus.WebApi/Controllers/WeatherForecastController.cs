using Microsoft.AspNetCore.Mvc;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService loginService;

        public LoginController(ILogger<LoginController> logger, ILoginService loginService)
        {
            _logger = logger;
            this.loginService = loginService;
        }

        [HttpGet(Name = "GetLogin")]
        public Task<LoginDto> Get(CancellationToken token)
        {
            return loginService.GetIsLogin(token);
        }
    }
}
