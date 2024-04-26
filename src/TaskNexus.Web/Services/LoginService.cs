using System;
using TaskNexus.WebApi;

namespace TaskNexus.Web.Services
{
    public class LoginService
    {
        public async Task<LoginDto> GetIsLogin(CancellationToken token)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<LoginDto>("http://localhost:5275/Login", token);
        }
    }
}
