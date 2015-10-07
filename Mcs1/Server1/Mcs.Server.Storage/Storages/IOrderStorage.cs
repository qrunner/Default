using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mcs.DataModel;

namespace Mcs.Services.Storage
{
    public interface IOrderStorage : IStorage<Order>
    {
        IEnumerable<Order> GetAllOfPlace(int placeId, int skip, int take);

        IEnumerable<Order> GetAll(int placeId, OrderState state, DateTime from, DateTime to, int skip, int take);
    }
}