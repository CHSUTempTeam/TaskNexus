using Microsoft.AspNetCore.Mvc;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWereService wereService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWereService wereService)
        {
            _logger = logger;
            this.wereService = wereService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Task<IEnumerable<WeatherForecastDto>> Get(CancellationToken token)
        {
            return wereService.GetList(token);
        }
    }
}
