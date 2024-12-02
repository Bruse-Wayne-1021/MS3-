using static MS3_LMS.Enity.User.Member;

namespace MS3_LMS.Models.ResponeModel
{
    public class MemberResponse
    {
        public string Nic { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid? MemberID {  get; set; }
        public bool? IsVerify { get; set; }

        public Gender UserGender { get; set; }
        public string? ImageUrl { get; set; }
    }
}
