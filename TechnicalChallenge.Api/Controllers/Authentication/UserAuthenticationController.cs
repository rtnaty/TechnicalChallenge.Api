using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TechnicalChallenge.Api.Services;

namespace TechnicalChallenge.Api.Controllers.Authentication
{
    /// <summary>
    /// Authentication
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthenticationController : ControllerBase
    {
        private readonly IUserAuthenticationService _userAuthenticationService;

        public UserAuthenticationController(IUserAuthenticationService userAuthenticationService)
        {
            this._userAuthenticationService = userAuthenticationService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.Id))
            {
                return BadRequest("Missing login details");
            }

            var loginResponse = await _userAuthenticationService.Login(loginRequest);

            if (loginResponse == null)
            {
                return BadRequest($"Invalid credentials");
            }

            return Ok(loginResponse);
        }
    }
}
