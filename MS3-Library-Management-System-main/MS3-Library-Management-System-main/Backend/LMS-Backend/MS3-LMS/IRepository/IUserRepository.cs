using MS3_LMS.Enity.User;

namespace MS3_LMS.IRepository
{
    public interface IUserRepository
    {
        Task createMemeber(Member member);
        Task createUser(User user);
        Task CreteAdmin(User user);
        Task<User> LoginAsync(string email, string password);
    }
}
