using Common.Contracts.Services.User;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models.Requests.User;

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
        public async Task<IActionResult> GetUserById(int id)
        {
            await _userServices.GetUserByIdAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUserRequest(CreateUserRequest request)
        {
            await _userServices.AddUserAsync(new Common.Dtos.User.AddUserDetailDto
            {
                UserName = request.UserName,
                PasswordHash = request.PasswordHash,
                Gender = request.Gender,
                FullName = request.FullName,
                Age = request.Age,
                DateTimeOffset = request.DateTimeOffset,
                IsActive = request.IsActive
            }) ;
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUserRequest(UpdateUserRequest request)
        {
            await _userServices.UpdateUserAsync(new Common.Dtos.User.UpdateUserDetailDto
            {
                Age = request.Age,
                Id = request.Id,
                FullName =  request.FullName,
                Gender = request.Gender,
                 PasswordHash = request.PasswordHash,
                 UserName = request.UserName
            });
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUserAsync(int id)
        {
            await _userServices.DeleteUserAsync(id);
            return Ok();
        }
    }
}
