using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(){

            
            return View(ProductRepository.Products);
        }
        public IActionResult list()
        {
            return View(ProductRepository.Products);
        }
        public IActionResult Details(int id)
        {
            
            return View(ProductRepository.GetByProductId(id));
        }
    }
}