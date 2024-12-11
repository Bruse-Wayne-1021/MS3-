using MS3_LMS.Enity.Core;

namespace MS3_LMS.IRepository
{
    public interface ISubcriptionRepository
    {
        Task<MS3_LMS.Enity.Core.Subscription> NewSubcription(Subscription subscription);
        Task<Subscription> CheckSubIsActive(Guid memberid);
         Task<List<Subscription>> GetAllSubcription();
    }
}
