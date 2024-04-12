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
        public List<WeatherForecastDto> WeatherForecastDtos { get; set; }

        public IndexModel(ILogger<IndexModel> logger, WereService wereService)
        {
            _logger = logger;
            this.wereService = wereService;
        }

        public async Task OnGet()
        {
            var list = await wereService.GetList(default);
            WeatherForecastDtos = list;
        }
    }
}
