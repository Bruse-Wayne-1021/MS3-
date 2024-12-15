using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Mono.TextTemplating;
using MS3_LMS.IService;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{userID}")]
        public async Task<IActionResult> GetByUserId(Guid userID)
        {
            if (userID == Guid.Empty)
            {
                return BadRequest("User ID is invalid.");
            }

            try
            {
                var user = await _userService.GetByUserID(userID);
                if (user == null)
                {
                    return NotFound($"User with ID {userID} not found.");
                }

                return Ok(user);
            }
            catch (KeyNotFoundException ex)
            {
                // Return 404 if the user was not Found
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                // Log error details (or use a Logging Framework)
                Console.Error.WriteLine($"Error in GetByUserId: {ex.Message}");
                return StatusCode(500, "An internal server error occurred.");
            }
        }

    }


}
