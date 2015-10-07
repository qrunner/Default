using System.Collections.Generic;
using Mcs.Model;

namespace Mcs.Services
{
    public interface IDishService : IServiceBase<Dish>
    {        
        IEnumerable<Dish> GetOfCategory(int categoryId);

        IEnumerable<Dish> GetOfPlace(int placeId, string searchPattern);
    }
}