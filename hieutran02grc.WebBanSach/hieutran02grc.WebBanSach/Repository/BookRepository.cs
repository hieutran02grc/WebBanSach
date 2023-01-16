using hieutran02grc.WebBanSach.Data;
using hieutran02grc.WebBanSach.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace hieutran02grc.WebBanSach.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context = null;
        private readonly IConfiguration _configuration;

        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                LanguageId = model.LanguageId,
                TotalPages = model.TotalPages.HasValue ? model.TotalPages.Value : 0,
                UpdatedOn = DateTime.UtcNow,
                CoverImageUrl = model.CoverImageUrl,
                BookPdfUrl = model.BookPdfUrl
            };

            newBook.bookGallery = new List<BookGallery>();

            foreach (var file in model.Gallery)
            {
                newBook.bookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;

        }

        public Task<List<BookModel>> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public string GetAppName()
        {
            throw new NotImplementedException();
        }

        public Task<BookModel> GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookModel>> GetTopBooksAsync(int count)
        {
            throw new NotImplementedException();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            throw new NotImplementedException();
        }
    }
}
