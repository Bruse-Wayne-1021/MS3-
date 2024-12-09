using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Core
{
    public class Payment
    {
        [Key]
        public Guid  PaymentId { get; set; }
        public string Type { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public Guid SubId { get; set; }
        public Subscription Subscription { get; set; }
    }

}
