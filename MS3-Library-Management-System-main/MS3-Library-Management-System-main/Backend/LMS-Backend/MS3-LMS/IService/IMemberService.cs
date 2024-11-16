using MS3_LMS.Enity.User;
using MS3_LMS.Models.RequestModel;
using MS3_LMS.Models.ResponeModel;

namespace MS3_LMS.IService
{
    public interface IMemberService
    {
        Task CreateNewUser(MemberRequestModel memberRequestModel);
        Task NewMemeber(MemberRequestModel memberRequestModel);
        Task<MemberResponse> GetMemberByNic(string Nic);
        Task<List<MemberResponse>> GetAllMembers();
    }
}
