using System;
using TaskNexus.WebApi;

namespace TaskNexus.Web.Services
{
    public class WereService
    {
        public async Task<List<WeatherForecastDto>> GetList(CancellationToken token)
        {
            HttpClient httpClient = new HttpClient();
            // httpClient.BaseAddress();
            return await httpClient
                .GetFromJsonAsync<List<WeatherForecastDto>>("http://localhost:5275/WeatherForecast", token);

            // http://localhost:5275/ это хранить в конфиге appsetting.json
            // wereforacast надо указать в базовом классе потому что это

            await httpClient.PostAsJsonAsync<WeatherForecastDto>("http://localhost:5275/WeatherForecast", new WeatherForecastDto(), token){

            }
        }
    }
}
