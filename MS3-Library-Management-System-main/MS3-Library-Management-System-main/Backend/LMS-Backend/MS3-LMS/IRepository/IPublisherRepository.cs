using MS3_LMS.Enity.Book;

namespace MS3_LMS.IRepository
{
    public interface IPublisherRepository
    {
        Task<Publisher> PostPublisher(Publisher publisher);
        Task<List<MS3_LMS.Enity.Book.Publisher>> GetAllpublisger();
    }
}
