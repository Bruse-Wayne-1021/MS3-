using MS3_LMS.Enity.Core;
using MS3_LMS.IRepository;
using MS3_LMS.IService;
using MS3_LMS.LMSDbcontext;
using MS3_LMS.Models.RequestModel;
using MS3_LMS.Models.ResponeModel;

namespace MS3_LMS.Service
{
    public class BookLendService : IBookLendService
    {
        private readonly IBookLendRepository _bookLendRepository;
        private readonly LMSContext _lMSContext;

        public BookLendService(IBookLendRepository bookLendRepository ,LMSContext lMSContext)
        {
            _bookLendRepository = bookLendRepository;
            _lMSContext = lMSContext;
        }

        public async Task<BookLend> BookRequest(BookLendRequest bookLendRequest)
        {
            try
            {
                var request = new BookLend
                {
                    Status = bookLendRequest.Status,
                    LendDays = bookLendRequest.LendDays,
                    ReturnDate = bookLendRequest.ReturnDate,
                    ApprovedDate = bookLendRequest.ApprovedDate,
                    CollectDate = bookLendRequest.CollectDate,
                    Bookid = bookLendRequest.Bookid,
                    MemebID = bookLendRequest.MemebID

                };
                var daa = await _bookLendRepository.RequestBook(request);
                return daa;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

        public async Task<List<BookLendResponse>> GetBookLendResponsesAsync()
        {
            try
            {
                var data = await _bookLendRepository.GetAllRequestWithDeatails();
                var response =  data.Select(s => new BookLendResponse {
                    Status = s.Status,
                    LendDays = s.LendDays,
                    ReturnDate = s.ReturnDate,
                    ApprovedDate = s.ApprovedDate,
                    CollectDate = s.CollectDate,
                    Title = s.Book.Name,
                    MemberName = s.Member.FirstName,
                    Lastname = s.Member.FirstName,
                    Nic = s.Member.Nic,
                    Image1Path=s.Book.Image?.Image1Path,
                    Image2Path=s.Book.Image?.Image2Path


                }).ToList();
                return response;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<BookLendResponse>> EnumBasedResponse(BookLend.State state)
        {
            try
            {
                var data = await _bookLendRepository.GetEnumBaseRecords(state);
                var response = data.Select(data => new BookLendResponse
                {
                    Status = data.Status,
                    LendDays = data.LendDays,
                    ReturnDate = data.ReturnDate,
                    ApprovedDate = data.ApprovedDate,
                    CollectDate = data.CollectDate,
                    Title = data.Book.Name,
                    MemberName = data.Member.FirstName,
                    Lastname = data.Member.FirstName,
                    Nic = data.Member.Nic
                }).ToList();
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public async Task<BookLend>UpdateRecord(Guid id,BookLend.State state)
        {
            try
            {
                var member = await _lMSContext.BookLends.FindAsync(id) ?? throw new KeyNotFoundException("Member not found");
                member.Status = state;

                var res = await _bookLendRepository.UpdateState(member);
                return res;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }

        }



       
    }
}
