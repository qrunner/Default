using System.Collections.Generic;
using System.Web.Mvc;
using Mcs.Client.Logic;
using Mcs.Client.ViewModels;
using Mcs.Model;

namespace Mcs.Client.Controllers
{
    public class MenuController : Controller
    {
        readonly Storage.Storage _storage = new Storage.Storage();

        /// <summary>
        /// Представление: Список категорий блюд
        /// </summary>
        /// <returns>представление Список категорий блюд</returns>
        public ActionResult Menu()
        {
            return View(_storage.GetMenuCategories());
        }

        /// <summary>
        /// Представление: Список блюд, принадлежащих указанной категории
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <returns>Список блюд категории</returns>
        public ActionResult CategoryContent(int? id)
        {                        
            var dishExtList = GetCategoryDishQty(id.HasValue ? id.Value : 0);
            ViewBag.CategoryId = id;
            return View(dishExtList);
        }

        /// <summary>
        /// Возвращает список блюд, с предзаказанным количеством порций, принадлежащих указанной категории
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <returns>Список блюд, с предзаказанным количеством порций, принадлежащих указанной категории</returns>
        private IEnumerable<DishQty> GetCategoryDishQty(int id)
        {
            var dishList = _storage.GetCategoryContent(id);
            return GetDishExtList(dishList);
        }

        /// <summary>
        /// Возвращает список блюд, принадлежащих указанной категории
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <returns>Список блюд категории</returns>
        public ActionResult DefaultCategoryContent(int id)
        {
            return Json(GetCategoryDishQty(id));
        }

        /// <summary>
        /// Возвращает список блюд, отсортированных по названию
        /// </summary>
        /// <param name="searchStr">подсторока названия блюда</param>
        /// <returns>Список блюд</returns>
        public ActionResult SearchDishes(string searchStr)
        {
            var filteredDishes = _storage.SearchDishes(searchStr);
            var dishExtList = GetDishExtList(filteredDishes);
            return Json(dishExtList);
        }

        /// <summary>
        /// Преобразует исходный список блюд, к списку блюд с предзаказанным количеством порций
        /// </summary>
        /// <param name="dishList">Список блюд</param>
        /// <returns>Списк блюд с предзаказанным количеством порций</returns>
        private IEnumerable<DishQty> GetDishExtList(IEnumerable<Dish> dishList)
        {
            var dishQty = ShoppingCartBase.GetCart(HttpContext).GetDishQty();
            var dishExtList = new List<DishQty>();
            foreach (var dish in dishList)
            {
                var qty = 0;
                if (dishQty.ContainsKey(dish.DishId))
                    qty = dishQty[dish.DishId];
                dishExtList.Add(new DishQty(dish, qty));
            }
            return dishExtList;
        }
    }
}
