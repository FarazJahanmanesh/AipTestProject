using Common.Contracts.Repository.User;
using Common.Dtos.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.User
{
    public class UserRepository: IUserRepository
    {
        #region ctor 
            private readonly ApplicationDbContext _dbContext;
            public UserRepository(ApplicationDbContext dbContext)
            {

                _dbContext = dbContext;

            }
        #endregion
        #region crud for user
            public async Task AddUserAsync(AddUserDetailDto detailDto)
            {
                await _dbContext.Users.AddAsync(new Entities.User
                {

                });
                await _dbContext.SaveChangesAsync();
            }
            public async Task UpdateUserAsync(UpdateUserDetailDto detailDto, int id)
            {
            }
            public async Task GetUserAsync()
            {

            }
            public async Task GetUserByIdAsync(int id)
            {

            }
            public async Task DeleteUserAsync(int id)
            {

            }

        #endregion
    }
}
