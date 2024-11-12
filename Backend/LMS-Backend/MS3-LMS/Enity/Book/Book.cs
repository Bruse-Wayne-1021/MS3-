﻿using MS3_LMS.Enity.Core;

namespace MS3_LMS.Enity.Book
{
    public class Book
    {
        public Guid Bookid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int PageCount { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsEbook { get; set; }
        public string URL { get; set; }
        public int Quantity { get; set; }
        public Guid AuthorId { get; set; }
        public Guid PublisherId { get; set; }
        public Guid LanguageId { get; set; }

        public  Author? Author { get; set; }
        public  Publisher? Publisher { get; set; }
        public  Language? Language { get; set; }
        public  Image? Image { get; set; }
        public  ICollection<Rating>? Ratings { get; set; }
        public  ICollection<BookLend>? BookLends { get; set; }
    }

}
