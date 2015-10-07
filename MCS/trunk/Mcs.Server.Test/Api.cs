using System;
using System.Diagnostics;
using System.Linq;
using Mcs.Model.Json;
using Mcs.Server.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mcs.Server.Test
{
    [TestClass]
    public class Api
    {
        readonly PlaceController _placeController = new PlaceController();
        readonly DeskController _deskController = new DeskController();
        readonly NewsController _newsController = new NewsController();
        readonly PromoController _promosController = new PromoController();
        readonly CategoryController _mcatController = new CategoryController();
        readonly DishController _dishController = new DishController();
        readonly OrderController _orderController = new OrderController();
        readonly DeviceController _deviceController = new DeviceController();

        [TestMethod]
        public void TestApiControllers()
        {
            var places = _placeController.Get();
            Assert.IsNotNull(places);

            foreach (var place in places)
            {
                Assert.IsNotNull(_placeController.Get(place.Id));
                Trace.WriteLine(string.Format("Place: {0} {1}", place.Id, place.Name));

                // desks
                var desks = _deskController.Place(place.Id);
                Assert.IsNotNull(desks);
                foreach (var desk in desks)
                {
                    Assert.IsNotNull(_deskController.Get(desk.Id));
                    Trace.WriteLine(string.Format("Desk: {0} {1} {2}", desk.Id, desk.Name, desk.Reserved));
                }

                // news
                var news = _newsController.Place(place.Id);
                Assert.IsNotNull(news);
                foreach (var news_ in news)
                {
                    Assert.IsNotNull(_newsController.Get(news_.Id));
                    Trace.WriteLine(string.Format("News: {0} {1} {2}", news_.Id, news_.Title, news_.Visible));
                }

                // promos
                var promos = _promosController.Place(place.Id);
                Assert.IsNotNull(promos);
                foreach (var promo in promos)
                {
                    Assert.IsNotNull(_promosController.Get(promo.Id));
                    Trace.WriteLine(string.Format("Promo: {0} {1} {2}", promo.Id, promo.Title, promo.Visible));
                }

                int dishId = 0;

                // menu category
                var mcats = _mcatController.Place(place.Id);
                Assert.IsNotNull(mcats);
                foreach (var mcat in mcats)
                {
                    Assert.IsNotNull(_mcatController.Get(mcat.Id));
                    Trace.WriteLine(string.Format("Menu Category: {0} {1} {2}", mcat.Id, mcat.ParentId, mcat.Name));
                    var dishes = _dishController.Category(mcat.Id);
                    foreach (var dish in dishes)
                    {
                        Assert.IsNotNull(_dishController.Get(dish.Id));
                        Trace.WriteLine(string.Format("Dish: {0} {1} {2}", dish.Id, dish.Name, dish.Price));
                        dishId = dish.Id;
                    }
                }

                // orders
                var orders = _orderController.Place(place.Id);
                Assert.IsNotNull(orders);
                foreach (var order in orders)
                {
                    Assert.IsNotNull(_orderController.Get(order.Id));
                    Trace.WriteLine(string.Format("Order: {0} {1} {2}", order.Id, order.State, order.DeviceId));
                    foreach (var orderDish in order.Dishes)
                    {
                        Assert.IsNotNull(orderDish);
                        Trace.WriteLine(string.Format("Order Dish: {0} {1} {2}", orderDish.DishId, _dishController.Get(orderDish.DishId).Name, orderDish.Quantity));
                    }
                }

                int deviceId = _deviceController.DeviceId("DEVICE+X");
                
                var activeOrder = _orderController.Place(place.Id).SingleOrDefault(x => x.Id == desks.First().CurrentOrderId);
                if (activeOrder != null)
                {
                    activeOrder.Dishes = null;
                    activeOrder.State = OrderState.Closed;
                    _orderController.Post(activeOrder);
                }

                var newOrder = new Order
                {
                    PlaceId = place.Id,
                    DeviceId = deviceId,
                    DeskId = desks.First().Id,
                    Dishes = new[]
                    {
                        new OrderDish
                        {
                            DishId = dishId,
                            Quantity = 5
                        }
                    }
                };

                _orderController.Post(newOrder);

                Assert.IsTrue(_orderController.Active(deviceId).Any());
            }
        }

        [TestMethod]
        public void TestAddOrder()
        {
            
        }
    }
}