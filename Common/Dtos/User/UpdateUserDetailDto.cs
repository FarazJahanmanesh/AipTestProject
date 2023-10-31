using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos.User
{
    public class UpdateUserDetailDto
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
    }
}
