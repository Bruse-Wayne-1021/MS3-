using MS3_LMS.Enity.Core;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;
using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.Repository
{
    public class BookLendRepository: IBookLendRepository
    {
        private readonly LMSContext _DbContext;

        public BookLendRepository(LMSContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<BookLend>RequestBook(BookLend bookLend)
        {
            try
            {
                 await _DbContext.BookLends.AddAsync(bookLend);
                await _DbContext.SaveChangesAsync();
                return bookLend;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
