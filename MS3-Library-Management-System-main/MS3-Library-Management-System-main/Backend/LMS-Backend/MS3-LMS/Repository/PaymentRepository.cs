using MS3_LMS.Enity.Core;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;

namespace MS3_LMS.Repository
{
    public class PaymentRepository:IPaymentRepository
    {
        private readonly LMSContext _context;

        public PaymentRepository(LMSContext context)
        {
            _context = context;
        }

        public async Task<Payment>CreateNewPayment(Payment payment)
        {
            try
            {
                var data=await _context.Payments.AddAsync(payment);
                return data.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
