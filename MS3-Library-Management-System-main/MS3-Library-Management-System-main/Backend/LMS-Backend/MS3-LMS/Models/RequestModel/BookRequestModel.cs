using System.ComponentModel.DataAnnotations;

namespace MS3_LMS.Models.Request
{
    public class CreateBookRequest
    {
        [Required(ErrorMessage = "Book name is required.")]
        [MaxLength(200, ErrorMessage = "Book name cannot exceed 200 characters.")]
        public string Name { get; set; }

        [MaxLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "ISBN is required.")]
        [RegularExpression(@"^\d{3}-\d{10}$", ErrorMessage = "ISBN must be in the format 978-1234567890.")]
        public string ISBN { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Page count must be greater than 0.")]
        public int PageCount { get; set; }

        public bool IsAvailable { get; set; }

      

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Author ID is required.")]
        public Guid AuthorId { get; set; }

        [Required(ErrorMessage = "Publisher ID is required.")]
        public Guid PublisherId { get; set; }

        [Required(ErrorMessage = "Language ID is required.")]
        public Guid LanguageId { get; set; }

        [Required(ErrorMessage = "Genre ID is required.")]
        public Guid GenreId { get; set; }


        //public string? Image1Path { get; set; }
        public string? Image2Path { get; set; }
        
        public DateTime PublishDate { get; set; }


    }
}
