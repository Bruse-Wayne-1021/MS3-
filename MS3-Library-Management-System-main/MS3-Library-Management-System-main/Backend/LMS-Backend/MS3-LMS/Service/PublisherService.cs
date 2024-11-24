using MS3_LMS.Enity.Book;
using MS3_LMS.IRepository;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.Service
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        public async Task CretePublisher(PublisherRequestModel publisherRequestModel)
        {
            try
            {
                var pub = new Publisher
                {
                    Name = publisherRequestModel.Name,
                    Description = publisherRequestModel.Description,
                    Details = publisherRequestModel.Details,
                    PublishDate = publisherRequestModel.PublishDate,
                };
                await _publisherRepository.PostPublisher(pub);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
