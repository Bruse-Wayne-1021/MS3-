using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.User
{
    public class UserRole
    {
        
        public Guid? UserId { get; set; }   
        public Guid? RoleID { get; set; }

        public  User? User { get; set; }
        public  Role? Role { get; set; }
    }

}
