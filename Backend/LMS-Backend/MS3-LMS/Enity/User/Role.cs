using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Enity.User
{
    public class Role
    {
        [Key]
        public Guid RoleID { get; set; }
        public enum uRole
        {
            Admin,
            Member
        };

        public uRole UserAType {  get; set; }

        public ICollection<UserRole>? UserRoles { get; set; }
    }

}
