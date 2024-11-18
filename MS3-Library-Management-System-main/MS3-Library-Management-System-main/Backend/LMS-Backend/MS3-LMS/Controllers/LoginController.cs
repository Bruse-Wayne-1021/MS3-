using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MS3_LMS.Enity.User;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _Userservice;
        private readonly IConfiguration _configuration;

        public LoginController(IUserService userservice,IConfiguration configuration)
        {
            _Userservice = userservice;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            var data=await _Userservice.login(model.Email, model.Password);
            return Ok(data);
        }


        private string createToken(User user,List<string>Roles)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creadentials=new SigningCredentials(key ,SecurityAlgorithms.HmacSha256);


            var claims = new List<Claim>
            {
               new Claim (JwtRegisteredClaimNames.Sub,user.Email),
               new Claim(JwtRegisteredClaimNames.Jti,Guid .NewGuid().ToString()),
               new Claim (ClaimTypes.NameIdentifier,user.UserId.ToString()),
               new Claim (ClaimTypes.Email,user.Email)

            };

            foreach(var role in Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims:claims,
                 expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:TokenExpiryInMinutes"])),
                signingCredentials: creadentials

             );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

    
    
}
