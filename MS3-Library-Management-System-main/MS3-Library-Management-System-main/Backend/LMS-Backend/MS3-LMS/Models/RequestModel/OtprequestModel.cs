using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Models.RequestModel
{
    public class OtprequestModel
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string OTPCode { get; set; }
    }

}
