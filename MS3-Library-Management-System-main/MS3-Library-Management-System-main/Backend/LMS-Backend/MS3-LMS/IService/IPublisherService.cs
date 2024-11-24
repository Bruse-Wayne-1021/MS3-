using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.IService
{
    public interface IPublisherService
    {
        Task CretePublisher(PublisherRequestModel publisherRequestModel);
    }
}
