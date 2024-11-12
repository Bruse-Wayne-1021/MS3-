namespace MS3_LMS.Enity.Book
{
    public class Publisher
    {
        public Guid PublisherId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string? Details { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }

}
