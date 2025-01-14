﻿using MS3_LMS.Enity.User;
using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Book
{
    public class Rating
    {
        [Key]
        public Guid RatingId { get; set; }
        [Range(1, 5, ErrorMessage = "Star count must be between 1 and 5.")]
        public int? StarCount { get; set; }
        public string? FeedBack { get; set; }
        public Guid MemebID { get; set; }
        public Guid Bookid { get; set; }

        public  Member? Member { get; set; }
        public  Book? Book { get; set; }
    }

}
