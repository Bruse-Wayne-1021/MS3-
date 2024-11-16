using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS3_LMS.Enity.User;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;
using MS3_LMS.Models.ResponeModel;
using MS3_LMS.Service;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberservice;

        public MemberController(IMemberService memberservice)
        {
            _memberservice = memberservice;
        }


        [HttpPost("NewMember")]
        public async Task<ActionResult> CreateNewMember(MemberRequestModel memberRequestModel)
        {
            await _memberservice.CreateNewUser(memberRequestModel);

            
            return CreatedAtAction(nameof(CreateNewMember), new { id = memberRequestModel.Nic }, memberRequestModel);
        }
        
        [HttpPost]
        [Route("new-member")]
        public async Task<IActionResult> NewMember([FromBody] MemberRequestModel memberRequestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _memberservice.NewMemeber(memberRequestModel);
                return Ok("Member and user created successfully, with default role assigned");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet]
        [Route("Get Member by id")]
        public async Task<IActionResult>getAllMembers(string Nic)
        {
            try
            {
                var member = await _memberservice.GetMemberByNic(Nic);
                if(member == null)
                {
                    return BadRequest(ModelState);
                }
                return Ok(member);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("Get all members")]
        public async Task<IActionResult> RetriveAllmembers()
        {
            try
            {
                var data = await _memberservice.GetAllMembers();
                if(data == null)
                {
                    return BadRequest(ModelState);
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
