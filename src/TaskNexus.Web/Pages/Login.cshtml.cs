using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskNexus.WebApi;

namespace TaskNexus.Web.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;
        public LoginDto canLogin { get; set; }

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        //public string OnGet() {

        //    var sett = isLoginService.GetIsLogin(default);
        //    canLogin = sett;

        //    return "True";
        //}
    }

}
