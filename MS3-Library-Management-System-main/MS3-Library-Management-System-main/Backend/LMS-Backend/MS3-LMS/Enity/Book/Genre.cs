using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
