using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
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
            var categories = new List<Category>()
            {
                new Category{Name="Telefon",Desciprtion="IOS"},
                new Category{Name="Bilgisayar",Desciprtion="Windows"},
                new Category{Name="Tablet",Desciprtion="IOS"},
                new Category{Name="Televizyon",Desciprtion="IOS"}

            };
            var models = new ProductViewModel{
                Categories = categories,
                Products = products
            };
            return View(models);
            
        }
        public IActionResult About()
        {
            return View();
        }
    }
}