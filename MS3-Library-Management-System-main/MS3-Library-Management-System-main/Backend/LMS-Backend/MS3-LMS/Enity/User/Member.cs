using Microsoft.EntityFrameworkCore;
using MS3_LMS.Enity.Book;
using MS3_LMS.Enity.Core;
using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.User
{
    [Index(nameof(Nic),  IsUnique = true)]
    public class Member
    {
        [Key]
        public Guid  MemebID { get; set; }
        public string   Nic { get; set; }
        public string?   FirstName { get; set; }
        
        public string?   LastName { get; set; }
        public string?  Email { get; set; }
        public string?  PhoneNumber { get; set; }
        public enum  Gender
        {
             Male,
             Female


        };
        public Gender  UserGender { get; set; }
        public string?  ImageUrl { get; set; }
        public bool?  IsVerify { get; set; }
        public Guid  UserId { get; set; }
        public  User?  User { get; set; }
        public  Restriction?  Restriction { get; set; }
        public  ICollection<Rating>?  Ratings { get; set; }
        public  ICollection<Subscription>?  Subscriptions { get; set; }
        public  ICollection<BookLend>?  BookLends { get; set; }
        
    }

}
