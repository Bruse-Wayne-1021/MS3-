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

        [HttpGet("Get by member by user id")]

        public async Task<IActionResult>GetByUSerId(Guid userID)
        {
            try
            {
                var data = await _userService.GetByUserID(userID);
                if (data == null)
                {
                    return BadRequest("Member not found");
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
