using Microsoft.AspNetCore.Mvc;

namespace BookStore1.Properties.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Aboutus()
        {
            return View("About");
        }
    }
}
