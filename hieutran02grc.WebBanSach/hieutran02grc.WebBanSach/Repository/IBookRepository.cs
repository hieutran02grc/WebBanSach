using hieutran02grc.WebBanSach.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using hieutran02grc.WebBanSach.Models;

namespace hieutran02grc.WebBanSach.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);
        Task<List<BookModel>> GetTopBooksAsync(int count);
        List<BookModel> SearchBook(string title, string authorName);

        string GetAppName();
    }
}