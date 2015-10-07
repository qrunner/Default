using System.Collections.Generic;
using System.Linq;
using Mcs.Model;

namespace Mcs.Services.MySql
{
    public class DishService : ServiceBase<Dish>, IDishService
    {
        public IEnumerable<Dish> GetOfCategory(int categoryId)
        {
            return Get(x => x.MenuCategoryId == categoryId);
        }

        public IEnumerable<Dish> GetOfPlace(int placeId, string searchPattern)
        {
            using (var ctx = new Context())
            {
                return ctx.Database.SqlQuery<Dish>("call dish_search(@placeid);", placeId).ToArray();
            }
        }
    }
}