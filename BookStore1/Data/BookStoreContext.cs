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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public DbSet<BookGallery> BookGallery { get; set; }

        public DbSet<Language> Language { get; set; }
=======
        public DbSet<Language> Language { get; set; }

>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        public DbSet<Language> Language { get; set; }

>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
        public DbSet<Language> Language { get; set; }

>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
    }   
}
