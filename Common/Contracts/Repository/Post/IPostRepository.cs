using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts.Repository.Post
{
    public interface IPostRepository
    {
        public Task AddPostAsync();
        public Task UpdatePostAsync();
        public Task GetPostAsync();
        public Task GetPostByIdAsync();
        public Task DeletePostAsync();
    }
}
