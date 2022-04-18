using Microsoft.AspNetCore.Mvc;

namespace BookStore1.Properties.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //# returns default view index.cshtml
            return View();
            //# returns view with full path 
            //return View("~/TempViews/YashView.cshtml");
            //# returns view with relative path 
            //return View("../../TempViews/YashView");

        }

        public ViewResult Aboutus()
        {
            return View("About");
        }

        public ViewResult Contactus()
        {
            return View();
        }
    }
}
