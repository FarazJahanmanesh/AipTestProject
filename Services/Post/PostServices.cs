using Common.Contracts.Repository.Post;
using Common.Contracts.Repository.User;
using Common.Contracts.Services.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Post
{
    public class PostServices: IPostServices
    {
        private readonly IPostRepository _repository;
        public PostServices(IPostRepository repository)
        {
            _repository = repository;
        }
        public async Task AddPostAsync() { }
        public async Task UpdatePostAsync() { }
        public async Task GetPostAsync() { }
        public async Task GetPostByIdAsync() { }
        public async Task DeletePostAsync() { }
    }
}
