using BookStore1.Models;
using BookStore1.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace BookStore1.Properties.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            ViewBag.Title = "Yash";
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Yash";
            ViewBag.Data = data;
            ViewBag.Type = new BookModel() { Id=5, Author="asdasd asdfasd"};

            ViewData["property1"] = "Yash Madariya";
            ViewData["book"] = new BookModel() { Id=6, Author = "asdasd asdfasd" };
            var books = _bookRepository.GetAllBooks();
            return View(books);
        }

        [Route("book-details/{id}", Name = "bookdetailsRoute")]
        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BookModel> SearchBooks(string bookname, string authername)
        {
            return _bookRepository.SearchBook(bookname, authername);
        }

        public ViewResult AddNewBook()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewBook(BookModel bookModel)
        {
            return View();
        }
    }
}
