using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Notification
{
    public class OTP
    {
        [Key]
        public Guid Id { get; set; }
        public string OTPCode { get; set; }
        public string Type { get; set; }
        public Guid UserId { get; set; }

        public MS3_LMS.Enity.User.User? User { get; set; }
    }

}
