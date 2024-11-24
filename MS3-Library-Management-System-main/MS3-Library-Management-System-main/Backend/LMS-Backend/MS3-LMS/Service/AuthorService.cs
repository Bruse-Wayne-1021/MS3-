using MS3_LMS.Enity.Book;
using MS3_LMS.IRepository;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IAothorRepository _aothorRepository;

        public AuthorService(IAothorRepository aothorRepository)
        {
            _aothorRepository = aothorRepository;
        }



        public async Task PostNewAuthor(AuthorRequestModel authorRequestModel)
        {
            try
            {
                var author = new Author
                {
                    Name = authorRequestModel.Name,
                    ImageUrl = authorRequestModel.ImageUrl,
                    Bio = authorRequestModel.Bio,
                };

                await _aothorRepository.PostNewAuthor(author);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
