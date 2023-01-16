using Microsoft.AspNetCore.Mvc;

namespace hieutran02grc.WebBanSach.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {

            //UserEmailOptions options = new UserEmailOptions
            //{
            //    ToEmails = new List<string>() { "test@gmail.com"},
            //    PlaceHolders = new List<KeyValuePair<string, string>>()
            //    {
            //        new KeyValuePair<string, string>("{{UserName}}", "John")
            //    }
            //};

            //await _emailService.SendTestEmail(options);

            //var userId = _userService.GetUserId();
            //var isLoggedIn = _userService.IsAuthenticated();

            //bool isDisplay = _newBookAlertconfiguration.DisplayNewBookAlert;
            //bool isDisplay1 = _thirdPartyBookconfiguration.DisplayNewBookAlert;

            //var value = _messageRepository.GetName();

            //var newBook = configuration.GetSection("NewBookAlert");
            //var result = newBook.GetValue<bool>("DisplayNewBookAlert");
            //var bookName = newBook.GetValue<string>("BookName");

            //var result = configuration["AppName"];
            //var key1 = configuration["infoObj:key1"];
            //var key2 = configuration["infoObj:key2"];
            //var key3 = configuration["infoObj:key3:key3obj1"];
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        // Uncomment the below line to enable roles on this action method.
        //[Authorize(Roles ="Admin,User")]
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
