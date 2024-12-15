using MS3_LMS.Enity.Core;

namespace MS3_LMS.IRepository
{
    public interface IPaymentRepository
    {
        Task<Payment> CreateNewPayment(Payment payment);   
    }
}
