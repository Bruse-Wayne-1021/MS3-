using Mono.TextTemplating;
using MS3_LMS.Enity.Core;
using MS3_LMS.IRepository;

namespace MS3_LMS.Models.RequestModel
{
    public class BookLendRequest
    {

        public MS3_LMS.Enity.Core.BookLend.State State { get; set; }
        public Guid Bookid { get; set; }
        public Guid MemebID { get; set; }
    }
}
