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


        public async Task<ViewResult> GetAllBooks()
        {
            ViewBag.Title = "Yash";
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Yash";
            ViewBag.Data = data;
            ViewBag.Type = new BookModel() { Id = 5, Author = "asdasd asdfasd" };

            ViewData["property1"] = "Yash Madariya";

            ViewData["book"] = new BookModel() { Id = 6, Author = "asdasd asdfasd" };


            var books = await _bookRepository.GetAllBooks();
            return View(books);
        }


        [HttpGet("get-book/{id}")]

        [Route("book-details/{id}", Name = "bookdetailsRoute")]

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

                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }

            return View();
        }


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
            var model = new BookModel();

            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View(model);
        }


    }
}

