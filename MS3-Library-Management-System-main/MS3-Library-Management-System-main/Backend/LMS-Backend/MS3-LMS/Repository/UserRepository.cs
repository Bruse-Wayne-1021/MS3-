using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using MS3_LMS.Enity.User;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

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


        public async Task<User?> LoginAsync(string email, string password)
        {
            try
            {
                
                var user = await _Context.Users
                    .Include(s => s.UserRoles)
                    .ThenInclude(r => r.Role)
                    .FirstOrDefaultAsync(u => u.Email == email);

                
                if (user == null)
                {
                    return null;
                }

                
                if (user.IsConfirmEmail != true)
                {
                    throw new InvalidOperationException("Email not confirmed. Please verify your email.");
                }

               
                if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    return null;
                }

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<Member>GetMemberByUSerId(Guid UserId)
        {
            try
            {
                var data = await _Context.Members.FirstOrDefaultAsync(m=>m.UserId==UserId);
                if (data == null)
                {
                    throw new Exception();
                }
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
