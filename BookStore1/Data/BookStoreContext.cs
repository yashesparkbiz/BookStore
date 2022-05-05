using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace BookStore1.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
            
        }

        public DbSet<Books> Book { get; set; }


        public DbSet<BookGallery> BookGallery { get; set; }

        public DbSet<Language> Language { get; set; }

    }   
}
