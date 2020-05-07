using System.Collections.Generic;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.ViewModels
{
    public class ProductViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}