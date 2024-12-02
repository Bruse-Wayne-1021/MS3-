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



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Member>()
                .HasOne(m => m.Restriction)
                .WithOne(r => r.Member)
                .HasForeignKey<Restriction>(r => r.MemebID);

            modelBuilder.Entity<Member>()
                .HasMany(m => m.Ratings)
                .WithOne(r => r.Member)
                .HasForeignKey(r => r.MemebID);

            modelBuilder.Entity<Member>()
                .HasMany(m => m.Subscriptions)
                .WithOne(s => s.Member)
                .HasForeignKey(s => s.MemebID);

            modelBuilder.Entity<Member>()
                .HasMany(m => m.BookLends)
                .WithOne(bl => bl.Member)
                .HasForeignKey(bl => bl.MemebID);

            //modelBuilder.Entity<Member>()
            //    .HasMany(m => m.Notifications)
            //    .WithOne(n => n.Member)
            //    .HasForeignKey(n => n.ReceiveId);

            modelBuilder.Entity<Member>()
                .HasOne(m => m.User)
                .WithOne(u => u.Member)
                .HasForeignKey<Member>(m => m.UserId);

            
            modelBuilder.Entity<User>()
                .HasMany(u => u.OTPs)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleID);

            modelBuilder.Entity<UserRole>()
                 .HasKey(ur => new { ur.UserId, ur.RoleID });


            modelBuilder.Entity<Book>()
                .HasMany(b => b.Ratings)
                .WithOne(r => r.Book)
                .HasForeignKey(r => r.Bookid);

            //modelBuilder.Entity<Book>()
            //    .HasMany(b => b.BookLends)
            //    .WithOne(bl => bl.Book)
            //    .HasForeignKey(bl => bl.Bookid);

            modelBuilder.Entity<Book>()
                .HasOne(b=>b.Genre)
                .WithMany(g=>g.Books)
                .HasForeignKey(b=>b.GenreId);
                

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Language)
                .WithMany(l => l.Books)
                .HasForeignKey(b => b.LanguageId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Image)
                .WithOne(i => i.Book)
                .HasForeignKey<Image>(i => i.Bookid);

            
            modelBuilder.Entity<Subscription>()
                .HasMany(s => s.Payment)
                .WithOne(p => p.Subscription)
                .HasForeignKey(p => p.SubId);


            modelBuilder.Entity<Role>().HasData(
                 new Role { RoleID = Guid.NewGuid(), UserAType = "Member" },
                 new Role { RoleID = Guid.NewGuid(), UserAType = "Admin" }
                  );


            modelBuilder.Entity<Language>().HasData(
                new Language { LanguageId = Guid.NewGuid(), TypeOfLanguage = "English" }, 
                new Language { LanguageId = Guid.NewGuid(), TypeOfLanguage = "Tamil" },
                new Language { LanguageId = Guid.NewGuid(), TypeOfLanguage = "Singalam" }
                );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Fiction", Description = "Fictional stories" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Non Fiction", Description = "Non-fictional content" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Science Fiction", Description = "Sci-fi stories" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Mystery", Description = "Mystery novels" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Thriller", Description = "Thrilling stories" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Romance Novel", Description = "Romantic tales" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Biography", Description = "Life stories of individuals" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Humor", Description = "Funny and comedic stories" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Fairy Tale", Description = "Fairy tales and folklore" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Graphic Novel", Description = "Stories told through illustrations" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "True Crime", Description = "Real-life crime stories" },
                new Genre { GenreId = Guid.NewGuid(), BookGenre = "Magical Realism", Description = "Stories blending magic and realism" }
            );



            base.OnModelCreating(modelBuilder);
        }


    }
}
