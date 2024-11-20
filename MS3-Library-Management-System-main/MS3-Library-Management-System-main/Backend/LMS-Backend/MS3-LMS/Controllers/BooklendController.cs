using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS3_LMS.Enity.Core;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;
using MS3_LMS.Models.ResponeModel;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooklendController : ControllerBase
    {
        private readonly IBookLendService _bookLendService;

        public BooklendController(IBookLendService bookLendService)
        {
            _bookLendService = bookLendService;
        }

        [HttpPost]
        public async Task<IActionResult> BooklendRequest(BookLendRequest bookLendRequest)
        {
            try
            {
                var data = await _bookLendService.BookRequest(bookLendRequest);
                if (data == null)
                {
                    return BadRequest();
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRequest()
        {
            try
            {
                var response = await _bookLendService.GetBookLendResponsesAsync();
                if (response == null)
                {
                    return BadRequest("there are no request");
                }
                return Ok(response);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("Booklend/Status/{state}")]
        public async Task<IActionResult>GetRecords(BookLend.State state)
        {
            try
            {
                var data = await _bookLendService.EnumBasedResponse(state);
                if(data == null)
                {
                    return BadRequest("Records Are Empty");
                }
                return Ok(data);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        [HttpPut]
        public async Task<IActionResult>UpdateState(Guid id, BookLend.State state)
        {
            try
            {
                var data = await _bookLendService.UpdateRecord(id, state);
                if(data == null)
                {
                    return BadRequest();
                }
                return Ok(data);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut("{memberid}/return-date")]
        public async Task<IActionResult>UpdateReturnDate(Guid MemberId, DateTime date)
        {
            try
            {
                var data = await _bookLendService.UpdatereturnDate(MemberId, date);
                if (data)
                {
                    return Ok("return date updateed");
                }
                return Ok("return date can,t update");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        
        

        
    }
}
