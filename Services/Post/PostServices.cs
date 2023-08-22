using Common.Contracts.Repository.Post;
using Common.Contracts.Repository.User;
using Common.Contracts.Services.Post;
using Common.Dtos.Post;
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
        public async Task AddPostAsync(AddPostDetailDto detailDto)
        {
            await _repository.AddPostAsync(detailDto);
        }
        public async Task UpdatePostAsync(UpdatePostDetailDto detailDto, int id)
        {
            await _repository.UpdatePostAsync(detailDto,id);
        }
        public async Task<List<GetPostDetailDto>> GetPostAsync()
        {
            return await _repository.GetPostAsync();        
        }
        public async Task<GetPostDetailDto> GetPostByIdAsync(int id) 
        {
            return await _repository.GetPostByIdAsync(id);
        }
        public async Task DeletePostAsync(int id) 
        {
            await _repository.DeletePostAsync(id);
        }
    }
}
