using BookStore1.Enum;
<<<<<<< HEAD
<<<<<<< HEAD
using BookStore1.Helpers;
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f

namespace BookStore1.Models
{
    public class BookModel
    {
        [DataType(DataType.Date)]
<<<<<<< HEAD
<<<<<<< HEAD
        [Display(Name = "Choose date")]
        public string MyField { get; set; }
        public int Id { get; set; }
        //[StringLength(100, MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter title of your book")]
        //[MyCustomValidation("Azure")]
=======
        [Display(Name ="Choose date")]
        public string MyField { get; set; }
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter title of your book")]
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        [Display(Name ="Choose date")]
        public string MyField { get; set; }
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter title of your book")]
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
        public string Title { get; set; }

        [Display(Name = "author name")]
        [Required(ErrorMessage = "Please enter Author name of your book")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please select language")]
        public int LanguageId { get; set; }


<<<<<<< HEAD
<<<<<<< HEAD
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
=======

        [Required(ErrorMessage = "Please choose language of your book")]
        public LanguageEnum LanguageEnum { get; set; }
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======

        [Required(ErrorMessage = "Please choose language of your book")]
        public LanguageEnum LanguageEnum { get; set; }
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
    }
}
