using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Core.Entities.DTO;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUsersService _usersService;
        public AuthenticationController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        [HttpPost("register")] //POST api/authentication/register
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid data");
            }
            var response = await _usersService.Register(request);
            if (response == null || !response.Success)
            {
                return BadRequest(response);
            }
            else
            {
                return Ok(response);
            }
        }
        [HttpPost("login")] //POST api/authentication/login
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid data");
            }
            var response = await _usersService.Login(request);
            if (response == null || !response.Success)
            {
                return Unauthorized(response);
            }
            else
            {
                return Ok(response);
            }
        }

    }
}
