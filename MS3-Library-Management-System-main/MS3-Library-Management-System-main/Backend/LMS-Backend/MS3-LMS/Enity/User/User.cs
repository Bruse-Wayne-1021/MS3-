using MS3_LMS.Enity.Notification;
using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.User
{
    public class User
    {
        [Key]
        public Guid  UserId { get; set; }
        [Required] 
        public string  Email { get; set; }
        public bool?  IsConfirmEmail { get; set; }
        public string?  PasswordHash { get; set; }

        public  Member?  Member { get; set; }


        public  ICollection<OTP>?  OTPs { get; set; }
        public  ICollection<UserRole>? UserRoles { get; set; }
    }

}
