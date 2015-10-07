using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mcs.DataModel;

namespace Mcs.Services.Storage
{
    public interface IMenuCategoryStorage : IStorage<MenuCategory>
    {
        IEnumerable<MenuCategory> GetAll(int placeId);
    }
}
