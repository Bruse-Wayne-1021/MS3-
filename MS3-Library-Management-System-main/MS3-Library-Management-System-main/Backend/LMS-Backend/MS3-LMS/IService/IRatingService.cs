using MS3_LMS.Enity.Book;

namespace MS3_LMS.IService
{
    public interface IRatingService
    {
        Task<Rating> PostRatingAsync(MS3_LMS.Models.RequestModel.RatingRequestModel ratingRequestModel);
    }
}
