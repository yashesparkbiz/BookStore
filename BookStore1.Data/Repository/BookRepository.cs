using BookStore1.Data.Models;
using BookStore1.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BookStore1.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context = null;

        private readonly IConfiguration _configuration;

        public BookRepository(BookStoreContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Id = model.Id,
                Title = model.Title,
                Author = model.Author,
                LanguageId = model.LanguageId,

                CoverImageurl = model.CoverImageurl,
                BookPdfurl = model.BookPdfurl,
            };

            newBook.bookGallery = new List<BookGallery>();

            foreach (var file in model.Gallery)
            {
                newBook.bookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL,
                });
            }

            await _context.Book.AddAsync(newBook);
            await _context.SaveChangesAsync();


            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allbooks = await _context.Book.ToListAsync();
            if (allbooks?.Any() == true)
            {
                foreach (var book in allbooks)
                {
                    books.Add(new BookModel()
                    {
                        Author = book.Author,
                        Id = book.Id,
                        Title = book.Title,
                        LanguageId = book.LanguageId,
                        CoverImageurl = book.CoverImageurl,
                        BookPdfurl = book.BookPdfurl
                    });
                }
            }
            return books;
        }


        public async Task<List<BookModel>> GetTopBooksAsync()
        {
            return await _context.Book.Select(book => new BookModel()
            {
                Author = book.Author,
                Id = book.Id,
                Title = book.Title,
                LanguageId = book.LanguageId,
                CoverImageurl = book.CoverImageurl,
                BookPdfurl = book.BookPdfurl
            }).Take(5).ToListAsync();
        }


        public async Task<BookModel> GetBookById(int id)
        {
            var book = await _context.Book.Where(x => x.Id == id).Select(books => new BookModel() { Title = books.Title, Author = books.Author, LanguageId = books.LanguageId, Gallery = books.bookGallery.Select(g => new GalleryModel() { Id = g.Id, Name = g.Name, URL = g.URL }).ToList(), BookPdfurl = books.BookPdfurl }).FirstOrDefaultAsync();
            return book;
        }

        public List<BookModel> SearchBook(string title, string authername)
        {
            return null;
        }

        public string GetAppName()
        {
            return _configuration["AppName"];
        }
    }
}
