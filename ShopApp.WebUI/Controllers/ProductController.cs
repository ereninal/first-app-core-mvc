using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
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
                new Product{Name = "Apple 6",Price=3000,Description="2016 date",Amount=5},
                new Product{Name = "Apple 6S",Price=4000,Description="2016 date",Amount=15},
                new Product{Name = "Apple 7",Price=5000,Description="2017 date",Amount=25},
                new Product{Name = "Apple 7 PLUS",Price=6000,Description="2017 date",Amount=4},
                new Product{Name = "Apple 8",Price=7000,Description="2018 date",Amount=2},
                new Product{Name = "Apple 8 PLUS",Price=8000,Description="2018 date",Amount=30},
            };
            var category = new Category{Name="Telefon",Desciprtion="IOS"};
            var models = new ProductViewModel{
                categorys =category,
                products = products
            };
            return View(models);
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