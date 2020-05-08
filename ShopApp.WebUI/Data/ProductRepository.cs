using System.Collections.Generic;
using ShopApp.WebUI.Models;
using System.Linq;
namespace ShopApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;
        public static List<Product> Products{
            get
            {
                return _products;
            }
        }
        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product{Id=1,Name = "Apple 6",Price=3000,Description="2016 date",Amount=5,ImageUrl="2.jpg"},
                new Product{Id=2,Name = "Apple 6S",Price=4000,Description="2016 date",Amount=15,ImageUrl="1.jpeg"},
                new Product{Id=3,Name = "Apple 7",Price=5000,Description="2017 date",Amount=25,ImageUrl="2.jpg"},
                new Product{Id=4,Name = "Apple 7 PLUS",Price=6000,Description="2017 date",Amount=4,ImageUrl="1.jpeg"},
                new Product{Id=5,Name = "Apple 8",Price=7000,Description="2018 date",Amount=2,ImageUrl="1.jpeg"},
                new Product{Id=6,Name = "Apple 8 PLUS",Price=8000,Description="2018 date",Amount=30,ImageUrl="1.jpeg"},
                
            };
        }
        
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static void DeleteProduct(Product product)
        {
            _products.Remove(product);
        }
        public static Product GetByProductId(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}