using Entities.Contracts.Services.User;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models.Requests.User;
using Services.Contracts;
using Services.Helper;

namespace MyApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices, IJwtService jwtService)
        {
            _jwtService = jwtService;
            _userServices = userServices;
        }


        [HttpGet]
        [Route("GenrateToken")]
        public async Task<IActionResult> GenrateToken()
        {
            var user = await _userServices.GetUserByIdAsync(2);
            var token = await _jwtService.Generate(user);
            return Ok(token);
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
