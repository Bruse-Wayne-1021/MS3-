using MS3_LMS.Enity.User;
using MS3_LMS.IRepository;
using MS3_LMS.LMSDbcontext;

namespace MS3_LMS.Repository
{
    public class MemberRepository: IMemberRepository
    {
        private readonly LMSContext _context;


        public MemberRepository(LMSContext context)
        {
            _context = context;
        }


        public async Task CreateNewUser(Member member)
        {
            try
            {
                await _context.Members.AddAsync(member);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                throw new Exception($"An error occurred while creating the member: {ex.Message}", ex);
            }
        }



    }
}
