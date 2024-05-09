using Microsoft.AspNetCore.Mvc;
using System;
using TaskNexus.WebApi;
using TaskNexus.WebApi.Abstractions;

namespace TaskNexus.WebApi.Services
{
    public class IsLoginService : IIsLoginService {

        public IsLoginDto GetIsLogin(CancellationToken token)
        {
            var isLogins = new IsLoginDto {
                isLogin = true,
            };

            return isLogins;
        }
    }




    public class ListProjectService : IListProjectService {

        public ListProjectDto GetIsLogin(CancellationToken token) {
            var isLogins = new ListProjectDto {
            };
            return isLogins;
        }
    }

    public class LoginService : ILoginService {

        public AnswerDto GetIsLogin([FromBody] LoginDto request, CancellationToken token) {


            request.Login = "a";

            var isLogins = new AnswerDto {
                Answer = "True"
            };

            return isLogins;
        }
    }



    public class RegistrationService : IRegistrationService {

        public RegistrationDto GetIsLogin(CancellationToken token) {
            var isLogins = new RegistrationDto {

            };

            return isLogins;
        }
    }



    public class ProjectService : IProjectService {

        public ProjectDto GetIsLogin(CancellationToken token) {
            var isLogins = new ProjectDto {

            };

            return isLogins;
        }
    }




    public class GetProjectService : IGetProjectService {

        public GetProjectDto GetIsLogin(CancellationToken token) {
            var isLogins = new GetProjectDto {

            };

            return isLogins;
        }
    }
    
    public class CreateProjectService : ICreateProjectService {

        public CreateProjectDto GetIsLogin(CancellationToken token) {
            var isLogins = new CreateProjectDto {

            };

            return isLogins;
        }
    }


}
