using BookStore1.Models;
using BookStore1.Repository;
using BookStore1.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace BookStore1.Properties.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly NewBookAlertConfig _newBookAlertconfiguration;
        private readonly NewBookAlertConfig _thirdPartyBookconfiguration;
        private readonly IMessageRepository _messageRepository;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        [ViewData]
        public string CustomProperty { get; set; }

        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public BookModel Book { get; set; }

        public HomeController(IOptionsSnapshot<NewBookAlertConfig> newBookAlertconfiguration, IMessageRepository messageRepository, IUserService userService, IEmailService emailService)
        {
            _newBookAlertconfiguration = newBookAlertconfiguration.Get("InternalBook");
            _thirdPartyBookconfiguration = newBookAlertconfiguration.Get("ThirdPartyBook");
            _messageRepository = messageRepository;
            _userService = userService;
            _emailService = emailService;
        }

        [HttpGet("~/")]
        [Authorize]
        public async Task<ViewResult> Index()
        {
            //UserEmailOptions options = new UserEmailOptions
            //{
            //    ToEmail = new List<string> { "test@gmail.com" },
            //    PlaceHolder = new List<KeyValuePair<string, string>>()
            //    {
            //        new KeyValuePair<string, string>("{{UserName}}", "Yash")
            //    }
            //};
            //await _emailService.SendTestEmail(options);
            var userId = _userService.GetUserId();
            var isLoggedIn = _userService.IsAuthenticated();
            //var newBookAlert = new NewBookAlertConfig();
            //_newBookAlertconfiguration.Bind("customobj", newBookAlert);
            bool isDisplay = _newBookAlertconfiguration.DisplayNewBookAlert;
            bool isDisplay1 = _thirdPartyBookconfiguration.DisplayNewBookAlert;
            //var value = _messageRepository.GetName();
            //# returns default view index.cshtml
            //var result = configuration.GetValue<bool>("DisplayNewBookAlert");

            //var result = configuration.GetSection("infoObj");
            //var key1 = result.GetValue<string>("key1");
            //var result = configuration["AppName"];
            //var key1 = configuration["InfoObj:key1"];
            //var key2 = configuration["InfoObj:key2"];
            //var key3 = configuration["InfoObj:key3:key3obj1"];
            //ViewData["CustomProperty"] = "Custom Value";
            return View();
            //# returns view with full path 
            //return View("~/TempViews/YashView.cshtml");
            //# returns view with relative path 
            //return View("../../TempViews/YashView");
        }
        

        [HttpGet]
        [Authorize]
        public ViewResult Aboutus()
        {
            return View("About");
        }

        [HttpGet]
        [Authorize]
        public ViewResult Contactus()
        {
            return View();
        }
    }
}
