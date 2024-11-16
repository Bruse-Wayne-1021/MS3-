using Mono.TextTemplating;

namespace MS3_LMS.Models.ResponeModel
{
    public class BookLendResponse
    {
        public Guid LendId { get; set; }
        public State Status { get; set; }
        public int LendDays { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? CollectDate { get; set; }
        public Guid Bookid { get; set; }
        public Guid MemebID { get; set; }
    }
}
