using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Models.RequestModel
{
    public class Login
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
