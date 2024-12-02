using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Models.RequestModel
{
    public class RatingRequestModel
    {
       
        public int? StarCount { get; set; }
        public string? FeedBack { get; set; }
        public Guid MemebID { get; set; }
        public Guid Bookid { get; set; }

    }
}
