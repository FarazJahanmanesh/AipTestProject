using Common.Contracts.Services.Post;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetPost()
        {
            await _postServices.GetPostAsync();
            return Ok();
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            await _postServices.GetPostByIdAsync();
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePost()
        {
            await _postServices.AddPostAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePost()
        {
            await _postServices.UpdatePostAsync();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeletePostAsync()
        {
            await _postServices.DeletePostAsync();
            return Ok();
        }
    }
}
