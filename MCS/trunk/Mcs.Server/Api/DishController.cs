using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Mcs.Model;
using Mcs.Server.JsonMappers;
using Mcs.Services;

namespace Mcs.Server.Api
{
    public class DishController : BaseApiController<Dish, IDishService, Model.Json.Dish>
    {
        [HttpGet]
        public IEnumerable<Model.Json.Dish> Category(int categoryId)
        {
            return ServiceInterface.GetOfCategory(categoryId).Select(Mapper.Map<Dish, Model.Json.Dish>);
        }
    }
}