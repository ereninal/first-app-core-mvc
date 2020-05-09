using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);
        }
    }
}