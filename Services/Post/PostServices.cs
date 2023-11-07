using Common.Dtos.Post;
using Entities.Contracts.Repository.Post;
using Entities.Contracts.Services.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Post
{
    public class PostServices: IPostServices
    {
        #region ctor  
            private readonly IPostRepository _repository;
            public PostServices(IPostRepository repository)
            {
                _repository = repository;
            }
        #endregion
        #region crud for postservice
            public async Task AddPostAsync(AddPostDetailDto detailDto)
            {
                await _repository.AddPostAsync(detailDto);
            }
            public async Task UpdatePostAsync(UpdatePostDetailDto detailDto, int id)
            {
                await _repository.UpdatePostAsync(detailDto, id);
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

        #endregion
    }
}
