using MS3_LMS.Models.RequestModel;
using MS3_LMS.Models.ResponeModel;

namespace MS3_LMS.IService
{
    public interface IAuthorService
    {
        Task PostNewAuthor(AuthorRequestModel authorRequestModel);

        Task<List<AuthorResponseModel>> GelAuthors();
    }
}
