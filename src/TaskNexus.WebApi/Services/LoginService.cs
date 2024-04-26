using System;
using TaskNexus.WebApi;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Services
{
    public class LoginService : ILoginService {

        public async Task<LoginDto> GetIsLogin(CancellationToken token)
        {
            var isLogins = new LoginDto
            {
                isLogin = true,
            };

            return isLogins;
        }
    }
}
