using MS3_LMS.Enity.Core;

namespace MS3_LMS.Models.ResponeModel
{
    public class BookLendResponse
    {

        public BookLend.State Status { get; set; }
        public int LendDays { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? CollectDate { get; set; }
        public string Title { get; set; }
        public string? MemberName { get; set; }
        public string? Lastname { get; set; }
        public string? Nic { get; set; }
        public string? Image1Path { get; set; }
        public string? Image2Path { get; set; }

    }
}
