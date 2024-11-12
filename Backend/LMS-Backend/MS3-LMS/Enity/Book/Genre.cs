namespace MS3_LMS.Enity.Book
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string BookGenre { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }

}
