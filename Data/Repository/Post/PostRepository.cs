using Common.Contracts.Repository.Post;
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
        public async Task AddPostAsync() { }
        public async Task UpdatePostAsync() { }
        public async Task GetPostAsync() { }
        public async Task GetPostByIdAsync() { }
        public async Task DeletePostAsync() { }
    }
}
