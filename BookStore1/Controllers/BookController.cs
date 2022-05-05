using BookStore1.Models;
using BookStore1.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;


namespace BookStore1.Properties.Controllers
{
    [Route(Route.Name)]
    public class BookController : Controller
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public class Route
        {
            public const string Name = "Book";
        }

        private readonly IBookRepository _bookRepository = null;
        private readonly ILanguageRepository _languageRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BookController(IBookRepository bookRepository, ILanguageRepository languageRepository, IWebHostEnvironment webHostEnvironment)
        {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("get-all-books")]
=======
        private readonly BookRepository _bookRepository = null;
        private readonly LanguageRepository _languageRepository = null;

        public BookController(BookRepository bookRepository, LanguageRepository languageRepository)
        {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
        }
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        private readonly BookRepository _bookRepository = null;
        private readonly LanguageRepository _languageRepository = null;

        public BookController(BookRepository bookRepository, LanguageRepository languageRepository)
        {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
        }
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        private readonly BookRepository _bookRepository = null;
        private readonly LanguageRepository _languageRepository = null;

        public BookController(BookRepository bookRepository, LanguageRepository languageRepository)
        {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
        }
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
        public async Task<ViewResult> GetAllBooks()
        {
            ViewBag.Title = "Yash";
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Yash";
            ViewBag.Data = data;
            ViewBag.Type = new BookModel() { Id = 5, Author = "asdasd asdfasd" };

            ViewData["property1"] = "Yash Madariya";
<<<<<<< HEAD
            ViewData["book"] = new BookModel() { Id = 6, Author = "asdasd asdfasd" };

=======
            ViewData["book"] = new BookModel() { Id=6, Author = "asdasd asdfasd" };
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
            var books = await _bookRepository.GetAllBooks();
            return View(books);
        }

<<<<<<< HEAD
        [HttpGet("get-book/{id}")]
=======
        [Route("book-details/{id}", Name = "bookdetailsRoute")]
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookById(id);
            return View(data);
        }

        [HttpGet("search-book/{bookname}/{authername}")]
        public List<BookModel> SearchBooks(string bookname, string authername)
        {
            return _bookRepository.SearchBook(bookname, authername);
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        
        [HttpPost("add-new-book")]
        
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {

            if (ModelState.IsValid)
            {
                if (bookModel.CoverPhoto != null)
                {
                    string folder = "books/cover/";
                    bookModel.CoverImageurl = await UploadImage(folder, bookModel.CoverPhoto);
                }

                if (bookModel.GalleryFiles != null)
                {
                    string folder = "books/gallery/";
                    bookModel.Gallery = new List<GalleryModel>();

                    foreach (var file in bookModel.GalleryFiles)
                    {
                        var gallery = new GalleryModel()
                        {
                            Name = file.FileName,
                            URL = await UploadImage(folder, file)
                        };
                        bookModel.Gallery.Add(gallery);
                    }
                }

                if (bookModel.BookPdf != null)
                {
                    string folder = "books/pdf/";
                    bookModel.BookPdfurl = await UploadImage(folder, bookModel.BookPdf);
                }

=======
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if(ModelState.IsValid)
            {
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if(ModelState.IsValid)
            {
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if(ModelState.IsValid)
            {
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            //ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");

=======
            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
            //ViewBag.Language = new List<string>() { "Hindi", "English", "Dutch" };


            //ViewBag.Language = new List<SelectListItem>()
            //{
            //    new SelectListItem(){ Text = "Hindi", Value = "1" },
            //    new SelectListItem(){ Text = "English", Value = "2" },
            //    new SelectListItem(){ Text = "Dutch", Value = "3"},
            //    new SelectListItem(){ Text = "Tamil", Value = "4"},
            //    new SelectListItem(){ Text = "Urdu", Value = "5"},
            //    new SelectListItem(){ Text = "Chienes", Value = "6"},
            //};

            return View();
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {
            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return folderPath;
        }

        [HttpGet("add-new-book")]
        public async Task<ViewResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
            var languages = await _languageRepository.GetLanguages();
            var model = new BookModel();
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
=======
        public async Task<ViewResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        {
=======
        public async Task<ViewResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        {
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        public async Task<ViewResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        {
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
            //ViewBag.Language = new List<SelectListItem>()
            //{
            //    new SelectListItem(){ Text = "Hindi", Value = "1" },
            //    new SelectListItem(){ Text = "English", Value = "2" },
            //    new SelectListItem(){ Text = "Dutch", Value = "3"},
            //    new SelectListItem(){ Text = "Tamil", Value = "4"},
            //    new SelectListItem(){ Text = "Urdu", Value = "5"},
            //    new SelectListItem(){ Text = "Chienes", Value = "6"},
            //};
            var languages = await _languageRepository.GetLanguages();

            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId; 
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
            return View();
        }

        
    }
}
