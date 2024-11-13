using MS3_LMS.Enity.Book;

namespace MS3_LMS.IService
{
    public interface IBookService
    {
        Task<Book> CreateBookAsyn(Book book);
        Task<IReadOnlyList<Book>> GetBooksAsync();
        Task<bool> DeleteBook(Guid Id);
        Task<Book> GetBookId(Guid id);
        Task<IReadOnlyList<Book>> FilterByLanguage(string Language);
        Task<IReadOnlyList<Book>> FilterByGenre(string Genre);
        Task<IReadOnlyList<Book>> BasedOnBookType(Book.type booktype);
    }
}
