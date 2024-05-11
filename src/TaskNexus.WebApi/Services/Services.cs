using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Reflection.PortableExecutable;
using TaskNexus.WebApi;
using TaskNexus.WebApi.Abstractions;
using TaskNexus.WebApi.DatabaseConnect;
namespace TaskNexus.WebApi.Services
{
    public class SessionService : ISessionService {

        public AnswerDto GetAnswer(CancellationToken token) {
            
            int length = 20;
            string randomString = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
                                  .Select(s => s[new Random().Next(s.Length)]).ToArray());

            var answer = new AnswerDto {
                Answer = randomString,
            };

            return answer;
        }
    }



    public class IsLoginService : IIsLoginService {

        public IsLoginDto GetIsLogin(CancellationToken token)
        {
            var answer = new IsLoginDto {
                isLogin = true,
            };

            return answer;
        }
    }




    public class ListProjectService : IListProjectService {

        public ListProjectDto GetList(CancellationToken token, IdDto request) {
            var answer = new ListProjectDto {
            };
            return answer;
        }
    }

    public class LoginService : ILoginService {

        public AnswerDto GetAnswer(CancellationToken token, LoginDto request) {


            MySqlDataReader answerBD = DatabaseConnection.select("user", "EMAIL='"+ request.Login+"'");

            AnswerDto answer = new AnswerDto {
                Answer = "False",

            };

            if (answerBD.HasRows) {
                if (answerBD["PASSWORD"].ToString() == request.Password) {
                    
                    answer.Answer = Encoder.generateSessionId();
                }
            }

            return answer;
        }
    }



    public class RegistrationService : IRegistrationService {

        public RegistrationDto GetIsLogin(CancellationToken token) {
            var answer = new RegistrationDto {

            };

            return answer;
        }
    }



    public class ProjectService : IProjectService {

        public ProjectDto GetIsLogin(CancellationToken token) {
            var answer = new ProjectDto {

            };

            return answer;
        }
    }




    public class GetProjectService : IGetProjectService {

        public GetProjectDto GetIsLogin(CancellationToken token) {
            var answer = new GetProjectDto {

            };

            return answer;
        }
    }
    
    public class CreateProjectService : ICreateProjectService {

        public CreateProjectDto GetIsLogin(CancellationToken token) {
            var answer = new CreateProjectDto {

            };

            return answer;
        }
    }


}
