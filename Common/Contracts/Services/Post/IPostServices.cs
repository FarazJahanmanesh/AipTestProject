using Common.Dtos.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts.Services.Post
{
    public interface IPostServices
    {
        public Task AddPostAsync(AddPostDetailDto detailDto);
        public Task UpdatePostAsync(UpdatePostDetailDto detailDto, int id);
        public Task<List<GetPostDetailDto>> GetPostAsync();
        public Task<GetPostDetailDto> GetPostByIdAsync(int id);
        public Task DeletePostAsync(int id);
    }
}
