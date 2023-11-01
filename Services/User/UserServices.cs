using Common.Contracts.Repository.User;
using Common.Contracts.Services.User;
using Common.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.User
{
    public class UserServices: IUserServices
    {
        #region ctor
        private readonly IUserRepository _repository;
        public UserServices(IUserRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region crud for UserServices
        public async Task AddUserAsync(AddUserDetailDto detailDto) { await _repository.AddUserAsync(detailDto); }
        public async Task UpdateUserAsync(UpdateUserDetailDto detailDto ) { await _repository.UpdateUserAsync(detailDto); }
        public async Task GetUserAsync() { await _repository.GetUserAsync(); }
        public async Task GetUserByIdAsync(int id) { await _repository.GetUserByIdAsync(id); }
        public async Task DeleteUserAsync(int id) { await _repository.DeleteUserAsync(id); }
        #endregion

    }
}
