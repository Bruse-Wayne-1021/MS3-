using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MS3_LMS.Enity.Book;
using MS3_LMS.Enity.Core;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;
using MS3_LMS.Models.RequestModel;
using NuGet.Protocol.Plugins;

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

        public async Task<List<BookLend>>GetAllRequestWithDeatails()
        {
            var data=await _DbContext.BookLends.Include(b=>b.Book).Include(b=>b.Book.Image).Include(M=>M.Member).ToListAsync();
            return data;
        }


        public async Task<List<BookLend>> GetEnumBaseRecords(BookLend.State state)
        {
            try
            {
                var data = await _DbContext.BookLends.Where(s => s.Status == state).Include(d => d.Book)
                    .Include(m => m.Member).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

        public async Task<BookLend>UpdateState(BookLend bookLend)
        {
            try
            {
                 _DbContext.BookLends.Update(bookLend);
               await _DbContext.SaveChangesAsync();
                return bookLend;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


       


        public async Task<BookLend>updatedate(Guid Id,DateTime date,string datetype)
        {
            try
            {
                var data = await _DbContext.BookLends.FirstOrDefaultAsync(g => g.MemebID == Id);
                if(data == null)
                {
                    return null;
                }

                switch (datetype.ToLower())
                {
                    case "return":
                        data.ReturnDate = date;
                        break;

                    case "approve":
                        data.ApprovedDate = date;
                        break;

                    case "collect":
                        data.CollectDate= date;
                        break;

                    default:
                        throw new ArgumentException("invalid  date type ");

                };
                _DbContext.BookLends.Update(data);
                await _DbContext.SaveChangesAsync();
                return data;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<BookLend>> OverDueAsync()
        {
            try
            {
                var data = await _DbContext.BookLends.Where(O => O.CollectDate.HasValue && O.CollectDate < DateTime.Now)
                    .Include(I => I.Book)
                    .Include(b => b.Member)
                    .ToListAsync();
                return data;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<BookLend>> GetDueDateBooks()
        {
            try
            {
                var today = DateTime.Now;

                var data = await _DbContext.BookLends.Where(b => b.CollectDate.HasValue && EF.Functions.DateDiffDay(b.CollectDate, today) == 6)
                    .Include(I => I.Book)
                    .Include(b => b.Member)
                    .ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }





    }
}
