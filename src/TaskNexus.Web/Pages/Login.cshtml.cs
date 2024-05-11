using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskNexus.Web.Services;
using TaskNexus.WebApi;

namespace TaskNexus.Web.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;
        private readonly LoginUService loginService;
        public AnswerDto answer { get; set; }

        public LoginModel(ILogger<LoginModel> logger, LoginUService loginService)
        {
            _logger = logger;
            this.loginService = loginService;
        }


        // public IActionResult OnGet(string login, string password);

        //public async Task<JsonResult> OnPost([FromBody] LoginDto loginDto) {
        //    // Далее можно использовать идентификатор сессии
        //    // для получения данных из сеанса
        //    var value = HttpContext.Session.GetString("Id");

        //    LoginDto request = new LoginDto();
        //    request.Login = loginDto.Login;
        //    request.Password = loginDto.Password;

        //    answer = await loginService.GetAnswer(default, request);

        //    HttpContext.Session.SetString("Id", answer.Answer);

        //    return new JsonResult(new { success = true });
        //}
    }

}
