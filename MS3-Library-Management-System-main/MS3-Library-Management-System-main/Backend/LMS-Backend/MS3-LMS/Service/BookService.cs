using MS3_LMS.Enity.Book;
using MS3_LMS.IRepository;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;
using MS3_LMS.Repository;

namespace MS3_LMS.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BookService> _logger;

        public BookService(IBookRepository bookRepository ,ILogger<BookService> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;

        }

        //public async Task CreateBookAsyn(BookRequestModel bookRequestModel)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Creating book with the following details: {@BookRequestModel}", bookRequestModel);

        //        var book = new Book
        //        {
        //            Name = bookRequestModel.Name,
        //            Description = bookRequestModel.Description,
        //            ISBN = bookRequestModel.ISBN,
        //            PageCount = bookRequestModel.PageCount,
        //            AuthorId = bookRequestModel.AuthorId,
        //            GenreId = bookRequestModel.GenreId,
        //            LanguageId = bookRequestModel.LanguageId,
        //            PublisherId = bookRequestModel.PublisherId,
        //            BookType = bookRequestModel.BookType,
        //            Quantity = bookRequestModel.Quantity
        //        };

        //        _logger.LogInformation("Book entity created: {@Book}", book);
        //        await _bookRepository.CreateBookAsync(book);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError("Error creating book: {Message}. StackTrace: {StackTrace}", ex.Message, ex.StackTrace);
        //        throw new Exception("An error occurred while creating the book.", ex);
        //    }
        //}


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

        public async Task<Book>CreateBook(Book book)
        {
            return await _bookRepository.PostNewBOok(book);
        }
    }
}
