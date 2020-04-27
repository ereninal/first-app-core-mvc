using System;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour =DateTime.Now.Hour;
            ViewBag.Greeting = hour>12 ? "İyi Günler" :"Günaydın";
            ViewBag.UserName = "Eren";
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}