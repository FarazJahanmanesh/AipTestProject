using Common.Enums;

namespace Common.Dtos.User
{
    public class AddUserDetailDto
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTimeOffset DateTimeOffset { get; set; } = DateTime.Now;
    }
}
