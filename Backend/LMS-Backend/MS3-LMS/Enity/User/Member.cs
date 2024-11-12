using MS3_LMS.Enity.Book;
using MS3_LMS.Enity.Core;

namespace MS3_LMS.Enity.User
{
    public class Member
    {
        public int MemebID { get; set; }
        public string Nlc { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public bool IsVerify { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Restriction Restriction { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        //public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<BookLend> BookLends { get; set; }
        //public virtual ICollection<Notification> Notifications { get; set; }
    }

}
