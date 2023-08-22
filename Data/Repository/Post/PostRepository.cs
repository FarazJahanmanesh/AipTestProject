using Common.Contracts.Repository.Post;
using Common.Dtos.Post;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Post
{
    public class PostRepository: IPostRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public PostRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddPostAsync(AddPostDetailDto detailDto)
        {
            await _dbContext.Posts.AddAsync(new Entities.Post
            {
                IsDeleted = false,
                Title= detailDto.Title,
                Description= detailDto.Description,
                UserId = detailDto.UserId,
                CategoryId = detailDto.CategoryId
            });
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdatePostAsync(UpdatePostDetailDto detailDto,int id) 
        { 
            var post = await _dbContext.Posts.SingleOrDefaultAsync(c=>c.Id==id);
            post.Title=detailDto.Title;
            post.Description=detailDto.Description;
            post.CategoryId=detailDto.CategoryId;
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<GetPostDetailDto>> GetPostAsync() 
        {
            List<GetPostDetailDto> allPosts =new List<GetPostDetailDto>();
            var posts =await _dbContext.Posts.AsNoTracking().Where(c=>c.IsDeleted==false).ToListAsync();
            foreach (var post in posts)
            {
                allPosts.Add(new GetPostDetailDto
                {
                    CategoryId = post.CategoryId,
                    Description = post.Description,
                    Title = post.Title,
                    UserId = post.UserId
                });
            }
            return allPosts;
        }
        public async Task<GetPostDetailDto> GetPostByIdAsync(int id) 
        {
            var posts = await _dbContext.Posts.AsNoTracking().Where(c=>c.Id==id&&c.IsDeleted==false).SingleOrDefaultAsync();
            return new GetPostDetailDto
            {
                UserId = posts.UserId,
                CategoryId= posts.CategoryId,
                Description= posts.Description,
                Title = posts.Title
            };
        }
        public async Task DeletePostAsync(int id)
        {
            var post = await _dbContext.Posts.Where(c => c.Id == id && c.IsDeleted == false).SingleOrDefaultAsync();
            post.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
        }
    }
}
