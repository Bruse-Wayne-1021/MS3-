using Microsoft.AspNetCore.Http.HttpResults;

namespace MS3_LMS.Models.ResponeModel
{
    public class LoginResponseModel
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public List<string>Roles { get; set; }
        public string Token { get; set; }
    }
}
