using Microsoft.AspNetCore.Mvc;
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
        public async Task<ListProjectDto> GetList(CancellationToken token, SessionDto request) {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<ListProjectDto>("http://localhost:5275/ListProject", token);
        }
    }

    public class LoginUService {
        public async Task<AnswerDto> Post(CancellationToken token, LoginDto request) {
            HttpClient httpClient = new HttpClient();
            // тут мы его должны получить
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("http://localhost:5275/GetLogin", token);

            // Получаем ответ и возвращаем его
            return await response.Content.ReadFromJsonAsync<AnswerDto>();
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


