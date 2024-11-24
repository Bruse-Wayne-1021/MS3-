using MS3_LMS.Enity.Book;

namespace MS3_LMS.IRepository
{
    public interface ILanguageRepository
    {
        Task<List<Language>> GetallLanguage();
    }
}
