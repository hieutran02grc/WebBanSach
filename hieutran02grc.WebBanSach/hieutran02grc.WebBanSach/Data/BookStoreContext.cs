

using Microsoft.EntityFrameworkCore;

namespace hieutran02grc.WebBanSach.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
           : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

    
    }
}
