using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MS3_LMS.Enity.Book
{
    public class Language
    {
        [Key]
        public Guid LanguageId { get; set; }
        public string TypeOfLanguage { get; set; }
        [JsonIgnore]

        public  ICollection<Book>? Books { get; set; }
    }

}
