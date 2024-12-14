using MS3_LMS.Enity.User;
using MS3_LMS.Models.RequestModel;
using MS3_LMS.Models.ResponeModel;

namespace MS3_LMS.IService
{
    public interface IUserService
    {
        Task  NewAdmin(UserRequestModel  userRequestModel);
        Task<LoginResponseModel> Login(string  email, string  password);
        Task<MS3_LMS.Models.RequestModel.MemberIDRequestModel> GetByUserID(Guid  userId);


    }
}
