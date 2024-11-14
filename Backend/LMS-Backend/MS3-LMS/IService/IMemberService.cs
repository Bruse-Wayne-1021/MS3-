using MS3_LMS.Enity.User;
using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.IService
{
    public interface IMemberService
    {
        Task CreateNewUser(MemberRequestModel memberRequestModel);
        Task NewMemeber(MemberRequestModel memberRequestModel);
    }
}
