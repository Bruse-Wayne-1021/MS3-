using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly MS3_LMS.IService.IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("NewAuthor")]
        public async Task <IActionResult>PostNewAuthor(AuthorRequestModel authorRequestModel)
        {
           await _authorService.PostNewAuthor(authorRequestModel);
            return Ok(authorRequestModel);
        }
    }
}
