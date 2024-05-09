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

        private readonly IsLoginService isLoginService;
        public List<WeatherForecastDto> WeatherForecastDtos { get; set; }

        public IsLoginDto canLogin { get; set; }

        public IndexModel(ILogger<IndexModel> logger, WereService wereService, IsLoginService isLoginService)
        {
            _logger = logger;
            this.wereService = wereService;
            this.isLoginService = isLoginService;
        }

        public async Task OnGet()
        {
            var list = await wereService.GetList(default);
            WeatherForecastDtos = list;

            var sett = await isLoginService.GetIsLogin(default);
            canLogin = sett;
        }
    }
}
