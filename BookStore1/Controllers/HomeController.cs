using BookStore1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore1.Properties.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }

        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public BookModel Book { get; set; }

        public ViewResult Index()
        {
            //# returns default view index.cshtml
            ViewData["CustomProperty"] = "Custom Value";
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
