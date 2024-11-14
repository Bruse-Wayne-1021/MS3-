using static MS3_LMS.Enity.User.Member;

namespace MS3_LMS.Models.RequestModel
{
    public class MemberRequestModel
    {
        public string Nic { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
       
        public Gender UserGender { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsVerify { get; set; }
        public Guid UserId { get; set; }
    }
}
