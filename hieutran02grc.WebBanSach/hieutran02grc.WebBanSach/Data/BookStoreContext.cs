
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hieutran02grc.WebBanSach.Models;



namespace hieutran02grc.WebBanSach.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
           : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        public DbSet<BookGallery> BookGallery { get; set; }

        public DbSet<Language> Language { get; set; }

        public DbSet<Category> Category { get; set; }

    }
}
