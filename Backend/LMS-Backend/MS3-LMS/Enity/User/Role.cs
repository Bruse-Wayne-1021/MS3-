namespace MS3_LMS.Enity.User
{
    public class Role
    {
        public Guid RoleID { get; set; }
        public enum UserRole
        {
            Admin,
            Member
        };

        public UserRole UserAType {  get; set; }

        public ICollection<UserRole>? UserRoles { get; set; }
    }

}
