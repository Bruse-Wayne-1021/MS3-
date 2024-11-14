using MS3_LMS.Enity.User;
using MS3_LMS.IRepository;
using MS3_LMS.IService;
using MS3_LMS.Models.RequestModel;
using MS3_LMS.Repository;
using NuGet.Protocol;

namespace MS3_LMS.Service
{
    public class MemberService: IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IRoleService _roleService;

        public MemberService(IMemberRepository memberRepository, IUserRepository userRepository, IRoleRepository roleRepository, IRoleService roleService)
        {
            _memberRepository = memberRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _roleService = roleService;
        }

        public async Task CreateNewUser(MemberRequestModel memberRequestModel)
        {
            var member = new Member
            {
                MemebID = Guid.NewGuid(),
                Nic = memberRequestModel.Nic,
                FirstName = memberRequestModel.FirstName,
                LastName = memberRequestModel.LastName,
                Email = memberRequestModel.Email,
                UserGender = memberRequestModel.UserGender,
                ImageUrl = memberRequestModel.ImageUrl,
                IsVerify = false,
                //UserId = Guid.NewGuid(),
                //PhoneNumber = memberRequestModel.PhoneNumber,
            };

            await _memberRepository.CreateNewUser(member);
        }


        public async Task NewMemeber(MemberRequestModel memberRequestModel)
        {
            var user = new User
            {
                Email = memberRequestModel.Email,
                IsConfirmEmail = false,
                

            };
            await _userRepository.createUser(user);

            var member = new Member
            {
                Nic = memberRequestModel.Nic,
                FirstName = memberRequestModel.FirstName,
                LastName = memberRequestModel.LastName,
                Email = memberRequestModel.Email,
                PhoneNumber = memberRequestModel.PhoneNumber,
                IsVerify = false,
                UserGender = memberRequestModel.UserGender,
                ImageUrl = memberRequestModel.ImageUrl,
                UserId=user.UserId
            };
            await _userRepository.createMemeber(member);

            await _roleService.AssignDefaultRole(user.UserId);
        }
    }
}
