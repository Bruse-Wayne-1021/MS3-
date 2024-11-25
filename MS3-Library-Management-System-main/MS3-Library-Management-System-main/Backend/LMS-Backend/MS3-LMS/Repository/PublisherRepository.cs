using Microsoft.EntityFrameworkCore;
using MS3_LMS.Enity.Book;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;

namespace MS3_LMS.Repository
{
    public class PublisherRepository: IPublisherRepository
    {
        private readonly LMSContext _context;

        public PublisherRepository(LMSContext context)
        {
            _context = context;
        }

        public async Task <MS3_LMS.Enity.Book.Publisher>PostPublisher(MS3_LMS.Enity.Book.Publisher publisher)
        {
            try
            {
                var data = await _context.AddAsync(publisher);
                await _context.SaveChangesAsync();
                return data.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public  async Task<List<MS3_LMS.Enity.Book.Publisher>>GetAllpublisger()
        {
            try
            {
               var data=  await _context.Publishers.ToListAsync();
                return data;
               


            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
