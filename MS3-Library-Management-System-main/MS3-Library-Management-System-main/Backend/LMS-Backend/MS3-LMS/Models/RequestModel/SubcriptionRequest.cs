using MS3_LMS.Enity.Core;

namespace MS3_LMS.Models.RequestModel
{
    public class SubcriptionRequest
    {

        public Guid MemebID { get; set; }  
        public Subscription.SubcriptionType SubType { get; set; }
        public bool IsActive { get; set; }
     
        public Payment.PaymentType PaymentType { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}
