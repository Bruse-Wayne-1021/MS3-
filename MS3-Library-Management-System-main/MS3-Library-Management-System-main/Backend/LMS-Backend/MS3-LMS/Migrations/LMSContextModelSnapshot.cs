﻿// <auto-generated />
using System;
using MS3_LMS.LMSDbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MS3_LMS.Migrations
{
    [DbContext(typeof(LMSContext))]
    partial class LMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MS3_LMS.Enity.Book.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Book", b =>
                {
                    b.Property<Guid>("Bookid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BookType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Bookid");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Genre", b =>
                {
                    b.Property<Guid>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BookGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = new Guid("40cb1813-c0b3-49b6-9d17-e2e664dca831"),
                            BookGenre = "Fiction",
                            Description = "Fictional stories"
                        },
                        new
                        {
                            GenreId = new Guid("27beed79-31f7-430a-8616-2226878b539b"),
                            BookGenre = "Non Fiction",
                            Description = "Non-fictional content"
                        },
                        new
                        {
                            GenreId = new Guid("7762ad72-dd33-4d71-ac9d-eedb339399aa"),
                            BookGenre = "Science Fiction",
                            Description = "Sci-fi stories"
                        },
                        new
                        {
                            GenreId = new Guid("eae049e0-ce65-4d5e-8c4a-e9bdb4521383"),
                            BookGenre = "Mystery",
                            Description = "Mystery novels"
                        },
                        new
                        {
                            GenreId = new Guid("ef6798d5-9f03-4689-a4b1-3f0e19cf02cf"),
                            BookGenre = "Thriller",
                            Description = "Thrilling stories"
                        },
                        new
                        {
                            GenreId = new Guid("5394cb99-0edd-4024-8b7f-4c54c6b0133c"),
                            BookGenre = "Romance Novel",
                            Description = "Romantic tales"
                        },
                        new
                        {
                            GenreId = new Guid("d4b7cdb9-7184-4f38-a715-35fd4e487479"),
                            BookGenre = "Biography",
                            Description = "Life stories of individuals"
                        },
                        new
                        {
                            GenreId = new Guid("36bb0a88-105b-46f9-93d5-600df1d15cb5"),
                            BookGenre = "Humor",
                            Description = "Funny and comedic stories"
                        },
                        new
                        {
                            GenreId = new Guid("d383566a-6b12-49d2-ba9b-a7d9f4bea8f0"),
                            BookGenre = "Fairy Tale",
                            Description = "Fairy tales and folklore"
                        },
                        new
                        {
                            GenreId = new Guid("e373b18f-081b-497c-ad1e-889f3c202484"),
                            BookGenre = "Graphic Novel",
                            Description = "Stories told through illustrations"
                        },
                        new
                        {
                            GenreId = new Guid("670bc5e3-c9b4-4d2d-8502-807616cc406c"),
                            BookGenre = "True Crime",
                            Description = "Real-life crime stories"
                        },
                        new
                        {
                            GenreId = new Guid("89c1bd30-a63f-471f-8c6a-aeba7d2e230e"),
                            BookGenre = "Magical Realism",
                            Description = "Stories blending magic and realism"
                        });
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Image", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Bookid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image1Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Bookid")
                        .IsUnique();

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Language", b =>
                {
                    b.Property<Guid>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeOfLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageId = new Guid("e00485ee-3045-4f0a-b95a-45197e48739b"),
                            TypeOfLanguage = "English"
                        },
                        new
                        {
                            LanguageId = new Guid("e75223ef-42c1-47d1-bf2f-f1765d600470"),
                            TypeOfLanguage = "Tamil"
                        },
                        new
                        {
                            LanguageId = new Guid("0af3c165-9359-43aa-9faa-cd9e95b305af"),
                            TypeOfLanguage = "Singala"
                        });
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Publisher", b =>
                {
                    b.Property<Guid>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Rating", b =>
                {
                    b.Property<Guid>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Bookid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FeedBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MemebID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StarCount")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("Bookid");

                    b.HasIndex("MemebID");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.BookLend", b =>
                {
                    b.Property<Guid>("LendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Bookid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CollectDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LendDays")
                        .HasColumnType("int");

                    b.Property<Guid>("MemebID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("LendId");

                    b.HasIndex("Bookid");

                    b.HasIndex("MemebID");

                    b.ToTable("BookLends");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SubId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("SubId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Restriction", b =>
                {
                    b.Property<Guid>("ResId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsRestricted")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemebID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResId");

                    b.HasIndex("MemebID")
                        .IsUnique();

                    b.ToTable("Restrictions");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Subscription", b =>
                {
                    b.Property<Guid>("SubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCancel")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemebID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SubType")
                        .HasColumnType("int");

                    b.HasKey("SubId");

                    b.HasIndex("MemebID");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Notification.Notification", b =>
                {
                    b.Property<Guid>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReceiveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ViewStatus")
                        .HasColumnType("bit");

                    b.HasKey("NotificationId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Notification.OTP", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OTPCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("OTPs");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Member", b =>
                {
                    b.Property<Guid>("MemebID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsVerify")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nic")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserGender")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MemebID");

                    b.HasIndex("Nic")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Role", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserAType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = new Guid("46d171df-34fe-4875-9d2c-ec7d4dc5afc5"),
                            UserAType = "Member"
                        },
                        new
                        {
                            RoleID = new Guid("50623b8a-ddd4-4939-8748-bd3cbb526f46"),
                            UserAType = "Admin"
                        });
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmEmail")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.UserRole", b =>
                {
                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleID");

                    b.HasIndex("RoleID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Book", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Book.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.Book.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.Book.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.Book.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");

                    b.Navigation("Language");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Image", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Book.Book", "Book")
                        .WithOne("Image")
                        .HasForeignKey("MS3_LMS.Enity.Book.Image", "Bookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Rating", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Book.Book", "Book")
                        .WithMany("Ratings")
                        .HasForeignKey("Bookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.User.Member", "Member")
                        .WithMany("Ratings")
                        .HasForeignKey("MemebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.BookLend", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Book.Book", "Book")
                        .WithMany()
                        .HasForeignKey("Bookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.User.Member", "Member")
                        .WithMany("BookLends")
                        .HasForeignKey("MemebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Payment", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Core.Subscription", "Subscription")
                        .WithMany("Payment")
                        .HasForeignKey("SubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Restriction", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.Member", "Member")
                        .WithOne("Restriction")
                        .HasForeignKey("MS3_LMS.Enity.Core.Restriction", "MemebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Subscription", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.Member", "Member")
                        .WithMany("Subscriptions")
                        .HasForeignKey("MemebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Notification.OTP", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.User", "User")
                        .WithMany("OTPs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Member", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.User", "User")
                        .WithOne("Member")
                        .HasForeignKey("MS3_LMS.Enity.User.Member", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.UserRole", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Book", b =>
                {
                    b.Navigation("Image");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Language", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Subscription", b =>
                {
                    b.Navigation("Payment");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Member", b =>
                {
                    b.Navigation("BookLends");

                    b.Navigation("Ratings");

                    b.Navigation("Restriction");

                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.User", b =>
                {
                    b.Navigation("Member");

                    b.Navigation("OTPs");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
