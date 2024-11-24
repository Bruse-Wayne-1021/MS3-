using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PubisherController : ControllerBase
    {
        private readonly IPublisherService _publisherService;

        public PubisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpPost("NewPublisher")]
        public async Task<IActionResult>postPublisher(PublisherRequestModel publisherRequestModel)
        {
            try
            {
                await _publisherService.CretePublisher(publisherRequestModel);
                return Ok("publisher created");
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
