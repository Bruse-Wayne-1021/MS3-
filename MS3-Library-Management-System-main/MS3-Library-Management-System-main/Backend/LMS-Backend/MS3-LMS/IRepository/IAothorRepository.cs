namespace MS3_LMS.IRepository
{
    public interface IAothorRepository
    {
        Task<MS3_LMS.Enity.Book.Author> PostNewAuthor(MS3_LMS.Enity.Book.Author author);
    }
}
