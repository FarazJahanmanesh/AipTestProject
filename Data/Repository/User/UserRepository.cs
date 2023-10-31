using Common.Contracts.Repository.User;
using Common.Dtos.User;
using Microsoft.EntityFrameworkCore;

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
                IsActive = true,
                Age=detailDto.Age,
                DateTimeOffset=detailDto.DateTimeOffset,
                Gender= detailDto.Gender,
                PasswordHash = detailDto.PasswordHash,
                UserName= detailDto.UserName,
                FullName=detailDto.FullName
            });
            await SaveChanges();
        }
        public async Task UpdateUserAsync(UpdateUserDetailDto detailDto, int id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(c => c.Id == id);
            user.Age = detailDto.Age;
            user.Gender=detailDto.Gender;
            detailDto.UserName = detailDto.UserName;
            detailDto.FullName = detailDto.FullName;
            detailDto.PasswordHash= detailDto.PasswordHash;
            await SaveChanges();
        }
        private async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
        public async Task GetUserAsync()
        {
            await _dbContext.Users.AsNoTracking().ToListAsync();
        }
        public async Task GetUserByIdAsync(int id)
        {
            await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(c=>c.Id==id);
        }
        public async Task DeleteUserAsync(int id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(c => c.Id == id);
            user.IsActive = false;
            await SaveChanges();
        }
        #endregion
    }
}
