using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using MS3_LMS.Enity.Book;
using MS3_LMS.Enity.Core;
using MS3_LMS.Enity.Notification;
using MS3_LMS.Enity.User;

namespace MS3_LMS.LMSDbcontext
{
    public class LMSContext:DbContext
    {
        public LMSContext(DbContextOptions<LMSContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre>Genres { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Rating> Rating { get; set; }

        public DbSet<BookLend> BookLends { get; set; }
        public DbSet<Payment>Payments { get; set; }
        public DbSet<Restriction>Restrictions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }  


        public DbSet<Notification>Notifications { get; set; }
        public DbSet<OTP> OTPs { get; set; }

        public DbSet<Member>Members { get; set; }
        public DbSet<User> Users { get;set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet <UserRole>UserRoles { get; set; }
    }
}
