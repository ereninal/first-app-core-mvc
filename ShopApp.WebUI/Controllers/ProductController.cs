using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using System.Collections.Generic;


namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(){

            var product = new Product{Name ="Apple 6",Price=2500,Description="2016 date"};
            var category = new Category{Name="Telefon",Desciprtion="IOS"};
            //ViewBag("product");
            ViewBag.category = category;;
            return View(product);
        }
        public IActionResult list()
        {
            var products = new List<Product>()
            {
                new Product{Name = "Apple 8",Price=3000,Description="2018 date"},
                new Product{Name = "Apple X",Price=5000,Description="2019 date"}
            };
            
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var p = new Product();
            p.Name = "Apple X";
            p.Price = 3000;
            p.Description ="New Phone";
            return View(p);
        }
    }
}