using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS3_LMS.IRepository;
using MS3_LMS.IService;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IBookLendService _bookLendService;

        public NotificationController(IBookLendService bookLendService)
        {
            _bookLendService = bookLendService;
        }


        [HttpPost("OverDueNotification")]
        public async Task<IActionResult> SendOverDueWarning()
        {
            try
            {
                 await _bookLendService.SendNotification();
                return Ok("Over Due sent Sucesss");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
