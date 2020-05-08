using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
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
            
            var models = new ProductViewModel{
                Categories =  CategoryRepository.Categories,
                Products = ProductRepository.Products
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