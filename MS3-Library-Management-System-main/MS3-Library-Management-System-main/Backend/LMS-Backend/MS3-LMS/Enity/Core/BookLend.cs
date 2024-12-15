using MS3_LMS.Enity.User;
using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Core
{
    public class BookLend
    {
        [Key]
        public Guid LendId { get; set; }

        public enum State
        {
           Favaurite,
           Request,
           Accept,
           Decline,
           Waiting,
           Borrowed

        }
        public State Status { get; set; }
        public int LendDays { get; set; }
        public DateTime? ReturnDate { get; set; }   
        public DateTime? ApprovedDate { get; set; }
        public DateTime? CollectDate { get; set; }
        public Guid Bookid { get; set; }
        public Guid MemebID { get; set; }

        public MS3_LMS.Enity.Book.Book Book { get; set; }
        public Member Member { get; set; }
    }

}
