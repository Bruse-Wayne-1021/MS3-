using MS3_LMS.Enity.User;

namespace MS3_LMS.Enity.Notification
{
    public class Notification
    {
        public Guid NotificationId { get; set; }
        public string? Type { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public bool? ViewStatus { get; set; }
        public Guid ReceiveId { get; set; }

        
    }

}
