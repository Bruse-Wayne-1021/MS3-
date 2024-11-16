using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Book
{
    public class Genre
    {
        [Key]
        public Guid GenreId { get; set; }
        public string BookGenre { get; set; }
        public string Description { get; set; }

        public  ICollection<Book>? Books { get; set; }
    }

}
