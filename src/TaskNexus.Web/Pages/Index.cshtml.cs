using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskNexus.Web.Services;
using TaskNexus.WebApi;

namespace TaskNexus.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WereService wereService;

        private readonly LoginService loginService;
        public List<WeatherForecastDto> WeatherForecastDtos { get; set; }

        public LoginDto canLogin { get; set; }

        public IndexModel(ILogger<IndexModel> logger, WereService wereService, LoginService loginService)
        {
            _logger = logger;
            this.wereService = wereService;
            this.loginService = loginService;
        }

        public async Task OnGet()
        {
            var list = await wereService.GetList(default);
            WeatherForecastDtos = list;

            var sett = await loginService.GetIsLogin(default);
            canLogin = sett;
        }
    }
}
