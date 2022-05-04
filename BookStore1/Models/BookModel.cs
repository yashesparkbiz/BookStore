using BookStore1.Enum;
using BookStore1.Helpers;

namespace BookStore1.Models
{
    public class BookModel
    {
        [DataType(DataType.Date)]
        [Display(Name = "Choose date")]
        public string MyField { get; set; }
        public int Id { get; set; }
        //[StringLength(100, MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter title of your book")]
        //[MyCustomValidation("Azure")]
        public string Title { get; set; }

        [Display(Name = "author name")]
        [Required(ErrorMessage = "Please enter Author name of your book")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please select language")]
        public int LanguageId { get; set; }


        //[Required(ErrorMessage = "Please choose language of your book")]
        //public LanguageEnum LanguageEnum { get; set; }

        [Display(Name = "Choose the cover photo of your book")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageurl { get; set; } = string.Empty;

        [Display(Name = "Choose the Gallery images of your book")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; }

        public List<GalleryModel> Gallery { get; set; } = new List<GalleryModel>() { };

        [Display(Name = "Upload your book in pdf format")]
        [Required]
        public IFormFile BookPdf { get; set; }
        public string BookPdfurl { get; set; } = string.Empty;
    }
}
