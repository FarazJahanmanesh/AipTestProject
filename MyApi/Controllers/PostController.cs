using Common.Dtos.Post;
using Entities.Contracts.Services.Post;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models.Requests;
using MyApi.Models.Requests.Post;

namespace MyApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostServices _postServices;
        public PostController(IPostServices postServices)
        {
            _postServices = postServices;
        }
        [HttpGet]
        [Route("GetPost")]
        public async Task<IActionResult> GetPost()
        {
            await _postServices.GetPostAsync();
            return Ok();
        }
        [HttpGet]
        [Route("GetPostById/{id:int}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            await _postServices.GetPostByIdAsync(id);
            return Ok();
        }
        [HttpPost]
        [Route("CreatePost")]
        public async Task<IActionResult> CreatePost([FromBody]AddPostRequests request)
        {
            await _postServices.AddPostAsync(new AddPostDetailDto{
                 CategoryId= request.CategoryId,
                 Description= request.Description,
                 IsDeleted= request.IsDeleted,
                 Title = request.Title,
                 UserId = request.UserId
            });
            return Ok();
        }
        [HttpPut]
        [Route("UpdatePost")]
        public async Task<IActionResult> UpdatePost([FromBody]UpdatePostRequests request)
        {
            await _postServices.UpdatePostAsync(new UpdatePostDetailDto
            {
                Title = request.Title,
                Description = request.Description,
                CategoryId= request.CategoryId
            }, request.Id);
            return Ok();
        }
        [HttpDelete]
        [Route("DeletePost/{id:int}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _postServices.DeletePostAsync(id);
            return Ok();
        }
    }
}
