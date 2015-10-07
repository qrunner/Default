using System.Linq;
using Mcs.Model;

namespace Mcs.Server.Controllers
{
    public class CategoryController : PlaceRelatedController<MenuCategory>
    {
        protected override void BeforeEdit(MenuCategory item)
        {
            var parentCats = ServiceInterface.GetOfPlace(Application.CurrentPlaceId).Where(x => x.Id != item.Id).ToList();
            parentCats.Insert(0, new MenuCategory() { Id = 0, Name = "(нет)" });
            ViewBag.ParentCategories = parentCats;
        }

        protected override void BeforeSave(MenuCategory item)
        {
            base.BeforeSave(item);
            if (item.ParentId == 0)
                item.ParentId = null;
        }
    }
}