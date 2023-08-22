using Common.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts.Repository.User
{
    public interface IUserRepository
    {
        public Task AddUserAsync(AddUserDetailDto detailDto);
        public Task UpdateUserAsync(UpdateUserDetailDto detailDto, int id);
        public Task GetUserAsync();
        public Task GetUserByIdAsync(int id);
        public Task DeleteUserAsync(int id);
    }
}
