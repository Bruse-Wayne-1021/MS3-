using MS3_LMS.Enity.User;
using MS3_LMS.IRepository;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;

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

        public async Task NewAdmin(MemberRequestModel memberRequestModel)
        {
            try
            {
                var user = new User
                {
                    Email = memberRequestModel.Email,
                    IsConfirmEmail = false,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(memberRequestModel.Password),
                
                };
                await _userRepository.CreteAdmin(user);


                var admin = new Member
                {
                    Nic = memberRequestModel.Nic,
                    Email = memberRequestModel.Email,
                    FirstName = memberRequestModel.FirstName,
                    LastName = memberRequestModel.LastName,
                    PhoneNumber = memberRequestModel.PhoneNumber,
                    ImageUrl = memberRequestModel.ImageUrl,
                    UserGender= memberRequestModel.UserGender,
                    UserId=user.UserId
                };

                await _memberRepository.CreateNewUser(admin);

                await _roleService.AssignAdmin(user.UserId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
