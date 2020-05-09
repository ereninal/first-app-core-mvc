using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;


namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            
            return View(ProductRepository.Products);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}