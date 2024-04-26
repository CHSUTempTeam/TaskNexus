namespace TaskNexus.WebApi.Abstractions {
    public interface ILoginService {
        LoginDto GetIsLogin(CancellationToken token);
    }
}