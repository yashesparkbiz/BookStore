using BookStore1.Models;
using BookStore1.Repository;
using Microsoft.AspNetCore.Mvc;

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
            var books = _bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookname, string authername)
        {
            return _bookRepository.SearchBook(bookname, authername);
        }
    }
}
