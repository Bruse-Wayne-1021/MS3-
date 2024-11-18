using MS3_LMS.Enity.Core;
using MS3_LMS.Enity.User;
using MS3_LMS.Models.RequestModel;
using MS3_LMS.Models.ResponeModel;

namespace MS3_LMS.IService
{
    public interface IMemberService
    {
        Task CreateNewUser(MemberRequestModel memberRequestModel);
        Task NewMemeber(MemberRequestModel memberRequestModel);
        Task<MemberResponse> GetMemberByNic(Guid Nic);
        Task<List<MemberResponse>> GetAllMembers();
        Task<List<BookLendResponse>> GetRecordsById(Guid id, BookLend.State state);
        Task<MemberResponse> EditMember(Guid id, MemberResponse memberResponse);
        Task<bool> DeleteMember(Guid id);
        Task<string> UpdateIsverify(Guid Memberid, bool isverify);
    }
}
