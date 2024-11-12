namespace MS3_LMS.Enity.Book
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string TypeOfLanguage { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }

}
