using System;
using TaskNexus.WebApi;

namespace TaskNexus.Web.Services
{
    public class IsLoginService
    {
        public async Task<IsLoginDto> GetIsLogin(CancellationToken token)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<IsLoginDto>("http://localhost:5275/IsLogin", token);
        }
    }


    public class ListProjectService {
        public async Task<ListProjectDto> GetIsLogin(CancellationToken token) {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<ListProjectDto>("http://localhost:5275/ListProject", token);
        }
    }


    public class LoginService {
        public async Task<LoginDto> GetAnswer(CancellationToken token) {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<LoginDto>("http://localhost:5275/Login", token);
        }
    }


    public class RegistrationService {
        public async Task<RegistrationDto> GetIsLogin(CancellationToken token) {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<RegistrationDto>("http://localhost:5275/Registration", token);
        }
    }


    public class ProjectService {
        public async Task<ProjectDto> GetIsLogin(CancellationToken token) {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<ProjectDto>("http://localhost:5275/Project", token);
        }
    }


    public class GetProjectService {
        public async Task<GetProjectDto> GetIsLogin(CancellationToken token) {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<GetProjectDto>("http://localhost:5275/GetProject", token);
        }
    }


    public class CreateProjectService {
        public async Task<CreateProjectDto> GetIsLogin(CancellationToken token) {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<CreateProjectDto>("http://localhost:5275/CreateProject", token);
        }
    }

}
