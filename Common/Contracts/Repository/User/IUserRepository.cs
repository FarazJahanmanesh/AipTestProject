using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts.Repository.User
{
    public interface IUserRepository
    {
        public Task AddUserAsync();
        public Task UpdateUserAsync();
        public Task GetUserAsync();
        public Task GetUserByIdAsync();
        public Task DeleteUserAsync();
    }
}
