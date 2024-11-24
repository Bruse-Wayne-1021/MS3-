using MS3_LMS.Models.ResponeModel;

namespace MS3_LMS.IService
{
    public interface ILanguageService
    {
        Task<List<LanguageResponseModel>> GetallLanguage();
    }
}
