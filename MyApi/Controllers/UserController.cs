using Common.Contracts.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices=userServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            await _userServices.GetUserAsync();
            return Ok();
        }
        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetUserById(long id)
        {
            await _userServices.GetUserByIdAsync();
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser()
        {
            await _userServices.AddUserAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser()
        {
            await _userServices.UpdateUserAsync();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUserAsync()
        {
            await _userServices.DeleteUserAsync();
            return Ok();
        }
    }
}
