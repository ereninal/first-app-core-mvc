using System.Collections.Generic;
using System.Linq;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        public static List<Category> Categories
        {
            get{return _categories;}
        }
        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category{Id=1,Name="Telefon",Desciprtion="IOS"},
                new Category{Id=2,Name="Bilgisayar",Desciprtion="Windows"},
                new Category{Id=3,Name="Tablet",Desciprtion="IOS"},
                new Category{Id=4,Name="Televizyon",Desciprtion="IOS"}
            };
        }
        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }
        public static void DeleteCategory(int id)
        {
            _categories.RemoveAt(id);
        }
        public static Category GetByCategoryId(int id)
        {
            return _categories.FirstOrDefault(c =>c.Id==id);
        }

    }
}