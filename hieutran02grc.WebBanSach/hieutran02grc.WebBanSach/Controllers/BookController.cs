using Microsoft.AspNetCore.Mvc;

namespace hieutran02grc.WebBanSach.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All books";
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
