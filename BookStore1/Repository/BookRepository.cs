using BookStore1.Models;

namespace BookStore1.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authername)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authername).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "a" },
                new BookModel() { Id = 2, Title = "Java", Author = "b" },
                new BookModel() { Id = 3, Title = ".Net", Author = "c" },
                new BookModel() { Id = 4, Title = "Node", Author = "d" },
                new BookModel() { Id = 5, Title = "Laravel", Author = "e" }
            };
        }
    }
}
