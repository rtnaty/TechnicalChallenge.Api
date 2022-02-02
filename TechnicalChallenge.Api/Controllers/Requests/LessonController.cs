using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TechnicalChallenge.Api.Services;

namespace TechnicalChallenge.Api.Controllers.Requests
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            this._lessonService = lessonService;
        }

        /// <summary>
        /// get request with parameter id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            if (HttpContext.User.Identity is not ClaimsIdentity claimsIdentity)
            {
                return Unauthorized("Invalid request");
            }
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim == null)
            {
                return Unauthorized("Invalid user");
            }

            var response = await _lessonService.GetLessonByUserAndLessonId(claim.Value, id);

            if (response == null)
            {
                return BadRequest($"No lesson was found");
            }

            return Ok(response);
        }
    }
}