using MS3_LMS.Enity.User;
using MS3_LMS.IRepository;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;
using System.Security.Permissions;

namespace MS3_LMS.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        
        private readonly IRoleRepository _roleRepository;
        private readonly IRoleService _roleService;
        private readonly IMemberRepository _memberRepository;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository userRepository, IRoleRepository roleRepository, IRoleService roleService,IMemberRepository memberRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _roleService = roleService;
            _memberRepository = memberRepository;
            _configuration = configuration;
        }

        public async Task NewAdmin(UserRequestModel userRequestModel)
        {
            try
            {
                var admin = new User
                {
                    Email = userRequestModel.Email,
                    IsConfirmEmail = true,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(userRequestModel.password),
                
                };
                await _userRepository.CreteAdmin(admin);


                //var admin = new Member
                //{
                //    Nic = memberRequestModel.Nic,
                //    Email = memberRequestModel.Email,
                //    FirstName = memberRequestModel.FirstName,
                //    LastName = memberRequestModel.LastName,
                //    PhoneNumber = memberRequestModel.PhoneNumber,
                //    ImageUrl = memberRequestModel.ImageUrl,
                //    UserGender= memberRequestModel.UserGender,
                //    UserId=user.UserId
                //};

                //await _memberRepository.CreateNewUser(admin);

                await _roleService.AssignAdmin(admin.UserId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        

        

        


    }
}
