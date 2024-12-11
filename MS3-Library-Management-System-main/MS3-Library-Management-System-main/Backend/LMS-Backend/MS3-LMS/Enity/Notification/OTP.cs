using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Notification
{
    public class OTP
    {
        [Key]
        public Guid Id { get; set; }
        public string OTPCode { get; set; }

        public enum WantedType
        {
            Register,
            ForgetPassword
        }

        public DateTime ExpiryTime { get; set; }
        public WantedType Type { get; set; }
        public Guid UserId { get; set; }

        public MS3_LMS.Enity.User.User? User { get; set; }
    }

}
