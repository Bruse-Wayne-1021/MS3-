using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IUserService _userSerVice;

        public AdminController(IUserService userSerVice)
        {
            _userSerVice = userSerVice;
        }

        [HttpPost]
        public async Task<IActionResult>DefineAdmin(MemberRequestModel memberRequestModel)
        {
            await _userSerVice.NewAdmin(memberRequestModel);

            return CreatedAtAction (nameof(DefineAdmin),new { id=memberRequestModel.Nic} ,memberRequestModel);
        }
    }

    

}
