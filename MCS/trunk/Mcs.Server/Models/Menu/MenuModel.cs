using System.Collections.Generic;
using Mcs.Model;

namespace Mcs.Server.Models.Menu
{
    public class MenuModel
    {
        int? _selectedCategory;

        public MenuModel(IEnumerable<MenuCategory> categories, IEnumerable<Dish> categoryDishes, int? selectedCategory)
        {
            Categories = categories;
            CategoryDishes = categoryDishes != null ? categoryDishes : new Dish[] { };
            _selectedCategory = selectedCategory;
        }

        public int SelectedCategory { get { return _selectedCategory.HasValue ? _selectedCategory.Value : 0; } }
        public IEnumerable<MenuCategory> Categories { get; private set; }
        public IEnumerable<Dish> CategoryDishes { get; private set; }
    }
}