using MS3_LMS.Enity.Book;
using MS3_LMS.IRepository;
using MS3_LMS.IService;

namespace MS3_LMS.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }



        public async Task<Book> CreateBookAsyn(Book book)
        {
            return await _bookRepository.CreateBookAsync(book);
        }

        public async Task<IReadOnlyList<Book>> GetBooksAsync()
        {
            return await _bookRepository.GetAllBooksAsync();
        }

        public async Task<bool> DeleteBook(Guid Id)
        {
            return await _bookRepository.DeleteBookByid(Id);
        }

        public async Task<Book> GetBookId(Guid id)
        {
            return await _bookRepository.GetBookByid(id);
        }

        public async Task<IReadOnlyList<Book>>FilterByGenre(string Genre)
        {
            return await _bookRepository.FilterByGenre(Genre);

        }
         public async Task<IReadOnlyList<Book>> FilterByLanguage(string Language)
        {
            return await _bookRepository.FilterByLanguage(Language);
        }
        
        public async Task<IReadOnlyList<Book>> BasedOnBookType(Book.type booktype)
        {
            return await _bookRepository.BasedOnBookType(booktype);
        }



    }
}
