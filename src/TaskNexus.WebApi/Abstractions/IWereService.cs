namespace TaskNexus.WebApi.Abstractions
{
    public interface IWereService
    {
        Task<IEnumerable<WeatherForecastDto>> GetList(CancellationToken token);
    }
}