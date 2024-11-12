namespace MS3_LMS.Enity.Book
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Bio { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }

}
