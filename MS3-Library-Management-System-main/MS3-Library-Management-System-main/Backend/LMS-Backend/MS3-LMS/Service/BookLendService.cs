using MS3_LMS.IRepository;

namespace MS3_LMS.Service
{
    public class BookLendService
    {
        private readonly IBookLendRepository _bookLendRepository;

        public BookLendService(IBookLendRepository bookLendRepository)
        {
            _bookLendRepository = bookLendRepository;
        }

        
    }
}
