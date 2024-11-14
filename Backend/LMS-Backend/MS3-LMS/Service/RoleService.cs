using MS3_LMS.IRepository;
using MS3_LMS.IService;

namespace MS3_LMS.Service
{
    public class RoleService:IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task AssignDefaultRole(Guid userId)
        {
            var role = await _roleRepository.GetRoleByNameAsync("Member");
            if (role != null)
            {
                await _roleRepository.AssignRoleTouser(userId,role.RoleID);
            }
        }
    }
}
