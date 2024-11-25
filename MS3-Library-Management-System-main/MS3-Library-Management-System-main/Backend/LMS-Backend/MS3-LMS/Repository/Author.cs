using Microsoft.EntityFrameworkCore;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;

namespace MS3_LMS.Repository
{
    public class Author: IAothorRepository
    {
        private readonly LMSContext _context;

        public Author(LMSContext context)
        {
            _context = context;
        }


        public async Task<MS3_LMS.Enity.Book.Author>PostNewAuthor(MS3_LMS.Enity.Book.Author author)
        {
            try
            {
                var data = await _context.Authors.AddAsync(author);
                await _context.SaveChangesAsync();
                return data.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<MS3_LMS.Enity.Book.Author>> GetAllAuthor()
        {
            try
            {
                
                var data = await _context.Authors.ToListAsync();

                
                return data;
            }
            catch (Exception ex)
            {
               
                throw new Exception($"Error fetching authors: {ex.Message}", ex);
            }
        }

    }
}
