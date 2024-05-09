using System.ComponentModel;

namespace TaskNexus.WebApi {
    public class AnswerDto {
        public string Answer { get; set; }
    }

    public class IsLoginDto {
        public bool isLogin { get; set; }
    }

    public class ListProjectDto {
        public string Id { get; set; }
        public List<String> Projects { get; set; }
    }

    public class LoginDto {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class RegistrationDto {
        public string Login { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public bool Answer { get; set; }
    }
    public class ProjectDto {
        public string IdProject { get; set; }
        public string Id { get; set; }
        public List<string> Messages { get; set; }
        public string Board { get; set; }
        public List<string> Members { get; set; }
    }

    
    public class GetProjectDto {
        public string Id { get; set; }
        public string IdProject { get; set; }
        public string PasswordProject { get; set; }
        public bool Answer { get; set; }
    }

    public class CreateProjectDto {
        public string NameProject { get; set; }
        public bool Answer { get; set; }
    }









} 


