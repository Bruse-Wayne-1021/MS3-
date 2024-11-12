using MS3_LMS.Enity.User;

namespace MS3_LMS.Enity.Book
{
    public class Rating
    {
        public Guid RatingId { get; set; }
        public int? StarCount { get; set; }
        public string? FeedBack { get; set; }
        public Guid MemebID { get; set; }
        public Guid Bookid { get; set; }

        public  Member? Member { get; set; }
        public  Book? Book { get; set; }
    }

}
