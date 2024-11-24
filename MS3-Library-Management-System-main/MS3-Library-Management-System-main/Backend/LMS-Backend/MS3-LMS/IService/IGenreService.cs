using MS3_LMS.Models.RequestModel;
using MS3_LMS.Models.ResponeModel;

namespace MS3_LMS.IService
{
    public interface IGenreService
    {
        Task CreteGenre(GenreRequestModel genreRequestModel);
        Task<List<GenreResponseModel>> GetAllGenres();
    }
}
