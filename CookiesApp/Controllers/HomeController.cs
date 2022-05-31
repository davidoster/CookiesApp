using CookiesApp.Models;
using CookiesApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CookiesApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICookieService _cookieService;

        public HomeController(ILogger<HomeController> logger, ICookieService cookieService)
        {
            _logger = logger;
            _cookieService = cookieService;
        }

        public IActionResult Index()
        {
            var clicksCounterCookieService = new CookieCategory<Cookie, ClicksCounter>();
            //var userSettingsCookieService = new CookieCategory<Cookie, UserSettings>();

            clicksCounterCookieService.ManageClicks();
            //clicksCounterCookieService.GetClicks();

            //userSettingsCookieService.ManageUserSettings();
            //userSettingsCookieService.GetUserSettings();
            
            // var clicksCounter = CookieServiceProvider.GetService(ICookieCategory<ClicksCounter>);
            var cookie = _cookieService.Get("clicksCounter");
            if (cookie != null) //HttpContext.Request.Cookies.ContainsKey("koukou"))
            {
                var koukou = cookie; //HttpContext.Request.Cookies["koukou"];
                Console.WriteLine(koukou);
                Debug.WriteLine(koukou);
            }
            else
            {
                _cookieService.Add("clicksCounter", "1"); // xService.AddCookieHandler(new ClicksCounter())
                // xService.AddCookieHandler(new CustomIdentityUser()) ICookieHandler
                // xService.AddCookieHaldler(new UserSettings()) // DarkTheme
                // yService.StoreCookieToDB(userSettings)
                //HttpContext.Response.Cookies.Append("koukou","koukou value");
            }
            //HttpContext.Response.Cookies.Append("koukou", "koukou value");
            return View();
        }

        public IActionResult Privacy()
        {
            _cookieService.Remove("clickCounter"); // count clicks Index
            // cookie -> UserName
            // cookie -> UserId
            // cookie -> UserEmail
            // cookie -> UserDOB
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
