using System;
using TaskNexus.WebApi;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Services
{
    public class WereService : IWereService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public async Task<IEnumerable<WeatherForecastDto>> GetList(CancellationToken token)
        {
            var range = Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            await Task.Delay(200, token);

            return range;
        }
    }
}
