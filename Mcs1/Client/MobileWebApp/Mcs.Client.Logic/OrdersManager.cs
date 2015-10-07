using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mcs.Model;

namespace Mcs.Client.Logic
{
    public class OrdersManager
    {
        readonly Storage.Storage _storage = new Storage.Storage();

        private string DeviceId { get; set; }

        public static OrdersManager GetManager(HttpContextBase context)
        {
            var manager = new OrdersManager { DeviceId = DeviceIdManager.GetDeviceId(context) };
            return manager;
        }

        public int CreateOrder(List<Cart> cartItems)
        {
            var order = new Order()
            {
                Desk_Id = 1,
                Device_Id = 1,
                State = 0,
                Opened = DateTime.Now,
                Closed = DateTime.Now
            };
            var orderDetails = cartItems.Select(item => new OrderDetail {Dish_Id = item.DishId, Quantity = item.Quantity, Order = order}).ToList();
            _storage.SaveOrder(order, orderDetails);
            return 1;
        }
    }
}
