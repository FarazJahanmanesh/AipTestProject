using Common.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Contracts.Services.User
{
    public interface IUserServices
    {
        public Task AddUserAsync(AddUserDetailDto detailDto);
        public Task UpdateUserAsync(UpdateUserDetailDto detailDto);
        public Task GetUserAsync();
        public Task<Entities.User> GetUserByIdAsync(int id);
        public Task DeleteUserAsync(int id);
    }
}
