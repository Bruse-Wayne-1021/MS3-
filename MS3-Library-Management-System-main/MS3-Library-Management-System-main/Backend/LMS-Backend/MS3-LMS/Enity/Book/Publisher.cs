using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Book
{
    public class Publisher
    {
        [Key]
        public Guid PublisherId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string? Details { get; set; }

        public  ICollection<Book>? Books { get; set; }
    }

}
