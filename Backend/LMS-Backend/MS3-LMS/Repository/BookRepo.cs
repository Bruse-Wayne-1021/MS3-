using Microsoft.EntityFrameworkCore;
using MS3_LMS.Enity.Book;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;

namespace MS3_LMS.Repository
{
    public class BookRepo : IBookRepository
    {
        private readonly ILogger<BookRepo> _logger;
        private LMSContext _context;

        public BookRepo(LMSContext context,ILogger<BookRepo>logger)
        {
            _context = context;
            _logger=logger;
        }


        public async Task<Book>CreateBookAsync(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book),"The Book object Can Not be null");
            }

            try
            {
                var data = await _context.Books.AddAsync(book);
                await _context.SaveChangesAsync();

                return data.Entity;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("An Eror Occured While creating Book ",ex);
            }

            catch(Exception ex)
            {
                throw new Exception("An UnExpected error", ex);
            }
        }

        public async Task<IReadOnlyList<Book>> GetAllBooksAsync()
        {
            try
            {
                
                var books = await _context.Books
                    //.Include(b => b.Author)
                    .Include(b => b.Genre)
                    //.Include(b => b.Publisher)
                    .Include(i=>i.Image)
                    .AsNoTracking()
                    .ToListAsync();

                return books;
            }
            catch (Exception ex)
            {
                
                throw new Exception("An error occurred while retrieving books.", ex);
            }
        }

        public async Task<bool>DeleteBookByid(Guid Id)
        {
            try
            {
                var book = await _context.Books.FindAsync(Id);
                if (book == null)
                {
                    throw new Exception();
                }
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception ex)
            {

                throw new Exception();

            }
        }


        public async Task<Book>GetBookByid(Guid id)
        {
            try
            {
                   var book=await _context.Books.FindAsync(id);

                if (book == null)
                {
                    _logger.LogWarning("Book with id notfound");
                    throw new KeyNotFoundException($"Book with id `{id}` not found");
                }
                return book;
            }
            catch(KeyNotFoundException Ex)
            {
                _logger.LogWarning(Ex.Message);

                throw;
            }
            catch(Exception Ex)
            {
                _logger.LogError(Ex.Message);
                throw new InvalidOperationException();
            }
        }





    }
}
