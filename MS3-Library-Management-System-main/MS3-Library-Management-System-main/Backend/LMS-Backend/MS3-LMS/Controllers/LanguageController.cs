using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
using MS3_LMS.IService;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
       private readonly MS3_LMS.IService.ILanguageService _languageService;

        public LanguageController(IService.ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet("AllLanguage")]
        public async Task<IActionResult> GetAllLanguage()     
        {
            try
            {
                var data = await _languageService.GetallLanguage();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
