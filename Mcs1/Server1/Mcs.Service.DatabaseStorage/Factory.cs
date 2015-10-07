using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mcs.DataModel;

namespace Mcs.Services.Storage.Database
{
    public class Factory : IStorageFactory
    {
        public IStorage<T> GetStorage<T>()
        {
            if (typeof(T) == typeof(Place))
                return new PlaceStorage() as IStorage<T>;

            if (typeof(T) == typeof(Desk))
                return new DeskStorage() as IStorage<T>;

            if (typeof(T) == typeof(MenuCategory))
                return new MenuCategoryStorage() as IStorage<T>;
            
            if (typeof(T) == typeof(Dish))
                return new DishStorage() as IStorage<T>;

            return null;
        }
    }
}
