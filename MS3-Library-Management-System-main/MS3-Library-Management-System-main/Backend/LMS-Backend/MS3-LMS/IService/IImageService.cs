using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.IService
{
    public interface IImageService
    {
        Task AddNewBook(ImageRequestModel imageRequestModel);
    }
}
