using Microsoft.Identity.Client;

namespace MS3_LMS.Models.ResponeModel
{
    public class AuthorResponseModel
    {
       public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string? ImageUrl { get; set; }
        public string? Bio { get; set; }
    }
}
