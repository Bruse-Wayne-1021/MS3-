using Microsoft.Build.Framework;
using MS3_LMS.Enity.User;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;

namespace MS3_LMS.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly LMSContext _Context;

        public UserRepository(LMSContext context)
        {
            _Context = context;
        }

        public async Task createUser(User user)
        {
            await _Context.Users.AddAsync(user);
            await _Context.SaveChangesAsync();
            
        }
        public async Task createMemeber(Member member)
        {
              await _Context.Members.AddAsync(member);
            await _Context.SaveChangesAsync();
        }



        public async Task CreteAdmin(User user)
        {
            await _Context.Users.AddAsync(user);
            await _Context.SaveChangesAsync();
        }


    }
}
