using System.ComponentModel;

namespace TaskNexus.WebApi {
    public class AnswerDto {
        public string Answer { get; set; }
    }

    public class IdDto {
        public string Id { get; set; }
    }
    public class IdProjectDto {
        public string Id { get; set; }
    }

    public class IsLoginDto {
        public bool isLogin { get; set; }
    }

    public class ListProjectDto {
        public List<string> Projects { get; set; }
    }

    public class LoginDto {
        public string Login { get; set; }
        public string Password { get; set; }
        public string? SessionId { get; set; }
    }

    public class RegistrationDto {
        public string Login { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
    }

    public class ProjectDto {
        public string IdProject { get; set; }
        public string Id { get; set; }
    }

    
    public class GetProjectDto {
        public string IdProject { get; set; }
    }

    public class CreateProjectDto {
        public string NameProject { get; set; }
    }


} 


