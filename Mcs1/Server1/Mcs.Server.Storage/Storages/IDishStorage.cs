using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mcs.DataModel;

namespace Mcs.Services.Storage
{
    public interface IDishStorage : IStorage<Dish>
    {
        IEnumerable<Dish> GetAllOfCategory(int categoryId);

        IEnumerable<Dish> GetAllOfPlace(int placeId);
    }
}