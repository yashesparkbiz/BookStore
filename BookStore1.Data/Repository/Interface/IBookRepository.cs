
using BookStore1.Data.Models;

namespace BookStore1.Data.Repository.Interface
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);
        Task<List<BookModel>> GetTopBooksAsync();
        List<BookModel> SearchBook(string title, string authername);

        string GetAppName();
    }
}