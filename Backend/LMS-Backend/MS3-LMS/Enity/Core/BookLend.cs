﻿using MS3_LMS.Enity.User;

namespace MS3_LMS.Enity.Core
{
    public class BookLend
    {
        public Guid LendId { get; set; }
        public string? Status { get; set; }
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
