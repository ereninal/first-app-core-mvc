using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var p = new Products();
            p.Name = "Apple X";
            p.Price = 3000;
            p.Description ="New Phone";
            return View(p);
        }
    }
}