using hieutran02grc.WebBanSach.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace hieutran02grc.WebBanSach.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All books";
        }

        public ViewResult GetBook()
        {
            return View();
        }


       
        public async Task<ViewResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            var model = new BookModel();

            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View(model);
        }



        public IActionResult Index()
        {
            return View();
        }

    }
}
