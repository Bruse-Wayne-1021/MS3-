using MS3_LMS.Enity.User;

namespace MS3_LMS.IRepository
{
    public interface IMemberRepository
    {
        Task CreateNewUser(Member member);
        Task<Member> GetMemberById(string Nic);
        Task<List<Member>> GetAllMembers();
    }
}
