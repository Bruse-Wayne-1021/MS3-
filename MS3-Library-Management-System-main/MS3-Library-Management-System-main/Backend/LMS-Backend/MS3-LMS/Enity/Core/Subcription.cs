using MS3_LMS.Enity.User;
using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Core
{
    public class Subscription
    {
        [Key]
        public Guid SubId { get; set; }
        public enum SubcriptionType
        {
            Month,
            Year
        };
        public SubcriptionType SubType { get; set; }

        public bool IsActive { get; set; } = false;
        public bool IsCancel { get; set; } = false;  
        public  Guid MemebID { get; set; }
        public  Member? Member { get; set; }

        public ICollection<Payment> Payment { get; set; }


    }

}
