using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MS3_LMS.Enity.Book;
using MS3_LMS.IService;
using MS3_LMS.LMSDbcontext;

namespace MS3_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LMSContext _context;
        private readonly IBookService _bookService;

        public BooksController(LMSContext context,IBookService bookService)
        {
            _context = context;
            _bookService = bookService;
        }

        // GET: api/Books
        [HttpGet]
       public async Task<IActionResult> GetallBooks()
        {
            var data = await _bookService.GetBooksAsync();

            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookByid(Guid id)
        {
            var book = await _bookService.GetBookId(id);


            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(Guid id, Book book)
        {
            if (id != book.Bookid)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Book>> CreateBookAsync(Book book)
        {
             var data=await _bookService.CreateBookAsyn(book);
            return Ok(data);
            //return CreatedAtAction("GetBook", new { id = book.Bookid }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            var book = await _bookService.DeleteBook(id);
            return Ok(book);


        }

        private bool BookExists(Guid id)
        {
            return _context.Books.Any(e => e.Bookid == id);
        }

        
    }
}
