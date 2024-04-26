namespace TaskNexus.WebApi.Abstractions {
    public interface ILoginService {
        Task<LoginDto> GetIsLogin(CancellationToken token);
    }
}