using Mono.TextTemplating;
using MS3_LMS.IRepository;

namespace MS3_LMS.Models.RequestModel
{
    public class BookLendRequest
    {
        
        public State Status { get; set; }
        public int LendDays { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? CollectDate { get; set; }
        public Guid Bookid { get; set; }
        public Guid MemebID { get; set; }
    }
}
