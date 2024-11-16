using MS3_LMS.Models.RequestModel;

namespace MS3_LMS.IService
{
    public interface IUserService
    {
        Task NewAdmin(UserRequestModel userRequestModel);
        
    }
}
