using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using TaskNexus.WebApi.Abstractions;
using TaskNexus.WebApi.DatabaseConnect;
namespace TaskNexus.WebApi.Services
{
    public class SessionService : ISessionService {


        // НЕ ТРОГАТЬ


        public AnswerDto GetAnswer(CancellationToken token) {
            
            int length = 20;
            List<Dictionary<string, object>> answerBD;

            var answer = new AnswerDto {
                Answer = "",
            };

            do {
                string randomString = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
                                      .Select(s => s[new Random().Next(s.Length)]).ToArray());

                answerBD = DatabaseConnection.getUserId(randomString);

                answer.Answer = randomString;

            } while(answerBD.Count != 0);

            return answer;
        }
    }


    public class ListProjectService : IListProjectService {

        public ListProjectDto GetList(CancellationToken token, SessionDto request) {

            ListProjectDto answer = new ListProjectDto {
                Projects = []
            };

            List<Dictionary<string, object>> answerBD = DatabaseConnection.getUserId(request.Session);

            foreach (Dictionary<string, object> abd in answerBD) {
                List<Dictionary<string, object>> answerBD2 = DatabaseConnection.getProjects(abd["USER"].ToString());

                foreach (Dictionary<string, object> abd2 in answerBD2) {
                    List<Dictionary<string, object>> answerBD3 = DatabaseConnection.select("project", "ID=" + abd2["ID_PROJECT"].ToString());
                    foreach (Dictionary<string, object> abd3 in answerBD3) {
                        answer.Projects.Add(abd3["TITLE"].ToString());
                    }
                }
            }

            return answer;
        }
    }

    public class LoginService : ILoginService {

        public AnswerDto GetAnswer(CancellationToken token, LoginDto request) {


            List<Dictionary<string, object>> answerBD = DatabaseConnection.select("user", "EMAIL='" + request.Login + "'");

            AnswerDto answer = new AnswerDto {
                Answer = "bad_login",

            };

            foreach (Dictionary<string, object> abd in answerBD) {
                if (abd["PASSWORD"].ToString() == request.Password) {

                    answer.Answer = Encoder.generateSessionId();
                    DatabaseConnection.addUserSession(answer.Answer, abd["ID"].ToString());
                }else {
                    answer.Answer = "bad_password";
                }
            }

            return answer;
        }
    }



    public class RegistrationService : IRegistrationService {

        public AnswerDto GetRegistration(CancellationToken token, RegistrationDto request) {
            AnswerDto answer = new AnswerDto {
                Answer = "False",
            };

            List<Dictionary<string, object>> answerBD = DatabaseConnection.select("user", "EMAIL='" + request.Login + "'");
            if (answerBD.Count == 0) {
                DatabaseConnection.addUser(request.Nickname, request.Login, request.Password);
                answer.Answer = "True";
            }

            return answer;
        }
    }

    public class CreateProjectService : ICreateProjectService {

        public AnswerDto GetAnswer(CancellationToken token, SessionDto request) {

            var answer = new AnswerDto {
                Answer = "False"
            };

            List<Dictionary<string, object>> answerBD = DatabaseConnection.getUserId(request.Session);
            foreach (Dictionary<string, object> abd in answerBD) {
                var id = abd["USER"];

                var id_project = DatabaseConnection.addProject("ПРОЕКТ");

                DatabaseConnection.addUserToProject(id_project, id.ToString());

                answer.Answer = "True";
            }

            return answer;
        }
    }

    public class RenameProjectService : IRenameProjectService {

        public AnswerDto GetAnswer(CancellationToken token, RenameProjectDto request) {
            var answer = new AnswerDto {
                Answer = "False"
            };

            List<Dictionary<string, object>> answerBD = DatabaseConnection.getUserId(request.Session);
            foreach (Dictionary<string, object> abd in answerBD) {
                DatabaseConnection.renameProject(abd["USER"].ToString(), request.NameProject, request.CountProject);
                answer.Answer = "True";
            }

            return answer;
        }
    }

    public class DeleteProjectService : IDeleteProjectService {

        public AnswerDto GetAnswer(CancellationToken token, DeleteProjectDto request) {
            var answer = new AnswerDto {
                Answer = "False"
            };
            List<Dictionary<string, object>> answerBD = DatabaseConnection.getUserId(request.Session);

            foreach (Dictionary<string, object> abd in answerBD) {
                DatabaseConnection.deleteProject(abd["USER"].ToString(), request.CountProject);
                answer.Answer = "True";
            }

            return answer;
        }
    }

    public class AddUserToProjectService : IAddUserToProjectService {

        public AnswerDto GetAnswer(CancellationToken token, AddUserToProjectDto request) {
            var answer = new AnswerDto {
                Answer = "False"
            };


            List<Dictionary<string, object>> answerBD = DatabaseConnection.getUserId(request.Session);

            foreach (Dictionary<string, object> abd in answerBD) {
                List<Dictionary<string, object>> answerBD2 = DatabaseConnection.getUserId(request.Session_Worker);
                foreach (Dictionary<string, object> abd2 in answerBD2) {
                    DatabaseConnection.addUserToProject(abd["USER"].ToString(), abd2["USER"].ToString(), request.CountProject);
                    answer.Answer = "True";
                }
            }

            return answer;
        }
    }

    // ТРОГАТЬ

    public class OutService : IOutService {

        public AnswerDto GetAnswer(CancellationToken token, SessionDto request) {

            var answer = new AnswerDto {
                Answer = "True"
            };

            DatabaseConnection.getOut(request.Session);
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



    




}
