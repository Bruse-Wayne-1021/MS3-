using MS3_LMS.Enity.User;
using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Core
{
    public class Restriction
    {
        [Key]
        public Guid ResId { get; set; }
        public bool? IsRestricted { get; set; }
        public string? Reason { get; set; }

        public Guid MemebID { get; set; }

        public  Member? Member { get; set; }
    }

}
