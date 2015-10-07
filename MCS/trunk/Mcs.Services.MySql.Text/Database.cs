using System;
using System.Collections.Generic;
using System.Linq;
using Mcs.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mcs.Services.MySql.Test
{
    [TestClass]
    public class Database
    {
        private readonly ServiceFactory _serviceFactory = new ServiceFactory();

        [TestMethod]
        public void TestCreateDatabase()
        {
            // Create database if not exists
            using (var contextDb = new Context())
            {
                contextDb.Database.Delete();
                contextDb.Database.CreateIfNotExists();
            }
        }

        [TestMethod]
        public void FillDatabase()
        {
            TestCreateDatabase();

            // PLACE
            var placeService = _serviceFactory.GetService<IPlaceService>();
            var goldenPalace = placeService.Get(x => x.Name == "Golden Palace").FirstOrDefault() ?? placeService.Save(new Place {Name = "Golden Palace"});
            Assert.IsNotNull(goldenPalace);
            Assert.IsTrue(goldenPalace.Id > 0);

            var uBobra = placeService.Save(new Place {Name = "Харчевня 'У Бобра'"});
            uBobra.Name = "Бобр";

            var bobrSaved = placeService.Save(uBobra);
            Assert.IsTrue(bobrSaved.Name == "Бобр");

            var bobrDb = placeService.Get(x => x.Id == uBobra.Id).First();
            Assert.IsNotNull(bobrDb);
            Assert.AreEqual(bobrDb.Name, uBobra.Name);

            placeService.Delete(bobrDb.Id);
            Assert.IsFalse(placeService.Get(x => x.Id == bobrDb.Id).Any());

            // DESK
            var deskService = CleanAndGetPlaceRelated<Desk>(goldenPalace.Id);
            var deskId = deskService.Save(new Desk {PlaceId = goldenPalace.Id, Name = "Стол 1 (VIP)", Reserved = false}).Id;
            Assert.AreEqual(1, deskService.GetOfPlace(goldenPalace.Id).Count());

            // DEVICE
            var deviceService = _serviceFactory.GetService<IDeviceService>();
            var deviceId = deviceService.GetDeviceId("X02");
            Assert.IsTrue(deviceId > 0);

            // MENU CATEGORIES
            var cats = CleanAndGetPlaceRelated<MenuCategory>(goldenPalace.Id);
            var categoryItems = new[]
            {
                cats.Save(new MenuCategory {PlaceId = goldenPalace.Id, Name = "Вина"}),
                cats.Save(new MenuCategory {PlaceId = goldenPalace.Id, Name = "Каши"}),
                cats.Save(new MenuCategory {PlaceId = goldenPalace.Id, Name = "Супы"})
            };
            var categories = cats.GetOfPlace(goldenPalace.Id);
            Assert.AreEqual(3, categories.Count());

            // DISHES
            var dishes = new List<Dish>();
            var dishService = _serviceFactory.GetService<IDishService>();
            foreach (var ci in categoryItems)
            {
                foreach (var dish in dishService.GetOfCategory(ci.Id))
                    dishService.Delete(dish.Id);

                dishes.Add(dishService.Save(new Dish {MenuCategoryId = ci.Id, Name = "Один из " + ci.Name, Price = 55}));
            }

            // NEWS
            var newsService = CleanAndGetPlaceRelated<News>(goldenPalace.Id);
            newsService.Save(new News {PlaceId = goldenPalace.Id, Title = "Новая новость", Date = DateTime.Now, Text = "Ого"});
            newsService.Save(new News {PlaceId = goldenPalace.Id, Title = "Срочное сообщение", Date = DateTime.Now, Text = "ОгоГо"});
            var news = newsService.GetOfPlace(goldenPalace.Id);
            Assert.AreEqual(2, news.Count());

            // PROMOS
            var promosService = CleanAndGetPlaceRelated<Promo>(goldenPalace.Id);
            promosService.Save(new Promo {PlaceId = goldenPalace.Id, Title = "Супер Акция!!!", Text = "Спешите к нам!"});
            var promos = promosService.GetOfPlace(goldenPalace.Id);
            Assert.AreEqual(1, promos.Count());

            // ORDERS
            var orderService = _serviceFactory.GetService<IOrderService>();
            var oldOrders = orderService.GetOfPlace(goldenPalace.Id);
            foreach (var oldOrder in oldOrders)
                orderService.Delete(oldOrder.Id);

            var order = new Order
            {
                PlaceId = goldenPalace.Id,
                DeviceId = deviceId,
                DeskId = deskId,
                Opened = DateTime.Now,
                State = OrderState.Draft
            };

            orderService.Save(order);
            Assert.IsTrue(order.Id > 0);

            var rnd = new Random();
            foreach (var d in dishes)
                orderService.ChangeDishQuantity(order.Id, d.Id, rnd.Next(5));

            Assert.AreEqual(3, orderService.Get(order.Id).Dishes.Count());
        }

        private IPlaceRelatedService<T> CleanAndGetPlaceRelated<T>(int placeId) where T : IPlaceRelatedEntity
        {
            var service = _serviceFactory.GetService<IPlaceRelatedService<T>>();
            foreach (var item in service.GetOfPlace(placeId))
                service.Delete(item.Id);

            return service;
        }
    }
}