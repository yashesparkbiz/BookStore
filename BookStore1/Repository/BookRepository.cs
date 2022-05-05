using BookStore1.Models;

namespace BookStore1.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context = null;
<<<<<<< HEAD
<<<<<<< HEAD
        private readonly IConfiguration _configuration;

        public BookRepository(BookStoreContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
=======
        public BookRepository(BookStoreContext context)
        {
            _context = context; 
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        public BookRepository(BookStoreContext context)
        {
            _context = context; 
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Id = model.Id,
                Title = model.Title,
                Author = model.Author,
                LanguageId = model.LanguageId,
<<<<<<< HEAD
<<<<<<< HEAD
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

=======
            };
            await _context.Book.AddAsync(newBook);
            await _context.SaveChangesAsync(); 
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
            };
            await _context.Book.AddAsync(newBook);
            await _context.SaveChangesAsync(); 
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
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
<<<<<<< HEAD
<<<<<<< HEAD
                        CoverImageurl = book.CoverImageurl,
                        BookPdfurl = book.BookPdfurl
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
                    });
                }
            }
            return books;
        }

<<<<<<< HEAD
<<<<<<< HEAD
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
=======
        public async Task<BookModel> GetBookById(int id)
        {
=======
        public async Task<BookModel> GetBookById(int id)
        {
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
            var books = await _context.Book.FindAsync(id);
            if(books != null)
            {
                var bookDetails = new BookModel() { Title = books.Title, Author = books.Author, LanguageId = books.LanguageId };
                return bookDetails;
            }
            return null;
<<<<<<< HEAD
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
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
