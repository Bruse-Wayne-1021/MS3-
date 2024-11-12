namespace MS3_LMS.Enity.Core
{
    public class Payment
    {
        public Guid  PaymentId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public Guid ReferenceId { get; set; }
    }

}
