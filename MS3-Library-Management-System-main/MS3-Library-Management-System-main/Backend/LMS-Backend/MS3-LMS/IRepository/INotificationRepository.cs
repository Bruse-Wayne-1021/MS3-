namespace MS3_LMS.IRepository
{
    public interface INotificationRepository
    {
        Task AddNotification(MS3_LMS.Enity.Notification.Notification notification);
        Task<List<MS3_LMS.Enity.Notification.Notification>> GetNotificationAsync(Guid MemberID);
    }
}
