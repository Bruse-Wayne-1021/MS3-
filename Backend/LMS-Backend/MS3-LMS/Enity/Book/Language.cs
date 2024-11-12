using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.Book
{
    public class Language
    {
        [Key]
        public Guid LanguageId { get; set; }
        public string TypeOfLanguage { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }

}
