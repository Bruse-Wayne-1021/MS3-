using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Book
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }
        public string BookGenre { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }

}
