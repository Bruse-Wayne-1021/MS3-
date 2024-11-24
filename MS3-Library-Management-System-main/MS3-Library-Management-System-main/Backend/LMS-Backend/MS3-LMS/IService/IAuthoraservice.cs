using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.IService
{
    public interface IAuthorService
    {
        Task PostNewAuthor(AuthorRequestModel authorRequestModel);
    }
}
