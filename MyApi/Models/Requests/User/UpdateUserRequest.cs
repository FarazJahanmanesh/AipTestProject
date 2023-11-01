using Common.Enums;

namespace MyApi.Models.Requests.User
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
    }
}
