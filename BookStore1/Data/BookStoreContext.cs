using Microsoft.EntityFrameworkCore;
namespace BookStore1.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
            
        }

        public DbSet<Books> Book { get; set; }

        
    }   
}
