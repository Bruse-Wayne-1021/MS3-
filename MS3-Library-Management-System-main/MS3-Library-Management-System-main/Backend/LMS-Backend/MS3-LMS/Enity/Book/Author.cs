using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MS3_LMS.Enity.Book
{
    public class Author
    {
        [Key]
        public Guid  AuthorId { get; set; }
        public string  Name { get; set; }
        public string?  ImageUrl { get; set; }
        public string?  Bio { get; set; }
        
        
        public ICollection<Book>?  Books { get; set; }
    }

}
