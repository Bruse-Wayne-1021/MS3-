namespace MS3_LMS.Enity.Book
{
    public class Image
    {
        public Guid ID { get; set; }
        public string? Image1Path { get; set; }
        public string? Image2Path { get; set; }
        public Guid Bookid { get; set; }

        public virtual Book? Book { get; set; }
    }

}
