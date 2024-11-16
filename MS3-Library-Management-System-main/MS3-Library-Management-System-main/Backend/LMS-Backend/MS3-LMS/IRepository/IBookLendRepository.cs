using MS3_LMS.Enity.Core;

namespace MS3_LMS.IRepository
{
    public interface IBookLendRepository
    {
        Task<BookLend> RequestBook(BookLend bookLend);
    }
}
