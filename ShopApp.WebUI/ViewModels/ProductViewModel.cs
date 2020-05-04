using System.Collections.Generic;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.ViewModels
{
    public class ProductViewModel
    {
        public Category categorys { get; set; }
        public List<Product> products { get; set; }
    }
}