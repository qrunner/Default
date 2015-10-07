using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mcs.DataModel;
using Provider.Database;
using Mcs.Service.Storage;

namespace Mcs.Services.DatabaseStorage.Test
{
    /// <summary>
    /// Сводное описание для UnitTest1
    /// </summary>
    [TestClass]
    public class DatabaseStorage
    {
        public DatabaseStorage()
        {
            _storageFactory = new Mcs.Service.Storage.Database.Factory();
        }

        private IStorageFactory _storageFactory;

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [ClassInitialize()]
        public static void CleanDatabase(TestContext testContext)
        {
            DatabaseContext context = new DatabaseContext("DefaultProvider");
            context.Execute("clean_database", true);
        }

        [TestMethod]
        public void Test01PlaceStorage()
        {
            IPlaceStorage placeStorage = (IPlaceStorage)_storageFactory.GetStorage<Place>();
            // add some places
            var placeNames = new[] { "Golden Palace", "У бобра" };
            List<Place> places = new List<Place>();
            foreach (var placeName in placeNames)
            {
                var place = placeStorage.Add(new Place() { Name = placeName });
                places.Add(place);
                Assert.IsNotNull(place);
                Assert.IsTrue(place.Id > 0);
            }

            // edit place
            places[1] = placeStorage.Set(places[1].Id, new Place() { Name = "Харчевня" });
            Assert.IsNotNull(places[1]);

            // get place
            var pl0 = placeStorage.Get(places[0].Id);
            Assert.AreEqual(places[0].Id, pl0.Id);
            Assert.AreEqual(places[0].Name, pl0.Name);

            // delete place
            placeStorage.Delete(places[1].Id);

            // check places count
            var pls = placeStorage.GetAll();
            Assert.AreEqual(pls.Count(), 1);
        }

        private Place GetPlace()
        {
            return ((IPlaceStorage)_storageFactory.GetStorage<Place>()).GetAll().First();
        }

        private IList<MenuCategory> GetCategories()
        {
            return new List<MenuCategory>(((IMenuCategoryStorage)_storageFactory.GetStorage<MenuCategory>()).GetAll(GetPlace().Id));
        }

        [TestMethod]
        public void Test02MenuCategoryStorage()
        {
            var placeId = GetPlace().Id;
            IMenuCategoryStorage mcatStorage = (IMenuCategoryStorage)_storageFactory.GetStorage<MenuCategory>();

            // add some categories
            var mcatNames = new[] { "Полукислые Вина", "Горячие блюда", "Каши", "Вина", "Салаты" };
            List<MenuCategory> cats = new List<MenuCategory>();
            foreach (var mcatName in mcatNames)
            {
                var mcat = mcatStorage.Add(new MenuCategory() { Name = mcatName, PlaceId = placeId });
                cats.Add(mcat);
                Assert.IsNotNull(mcat);
                Assert.IsTrue(mcat.Id > 0);
            }

            // edit category
            cats[0].ParentId = cats[3].Id;
            cats[0].Name = "Сухие Вина";
            cats[0] = mcatStorage.Set(cats[0].Id, cats[0]);

            // get category
            var cat0 = mcatStorage.Get(cats[0].Id);
            Assert.AreEqual(cats[0].Id, cat0.Id);
            Assert.AreEqual(cats[0].Name, cat0.Name);

            // delete category
            mcatStorage.Delete(cats[4].Id);

            // get categories
            Assert.IsTrue(mcatStorage.GetAll(placeId).Count() == 4);
        }

        [TestMethod]
        public void Test03DeskStorage()
        {
            var placeId = GetPlace().Id;
            IDeskStorage deskStorage = (IDeskStorage)_storageFactory.GetStorage<Desk>();

            // add some desks
            var deskNumbers = new[] { "VIP", "Верхний зал 1", "Верхний зал 2", "Быдло", "23" };
            List<Desk> desks = new List<Desk>();
            foreach (var deskNumber in deskNumbers)
            {
                var desk = deskStorage.Add(new Desk() { Number = deskNumber, PlaceId = placeId });
                desks.Add(desk);
                Assert.IsNotNull(desk);
                Assert.IsTrue(desk.Id > 0);
            }

            // edit desk            
            desks[3].Number = "20";
            desks[3] = deskStorage.Set(desks[3].Id, desks[3]);

            // get desk
            var cat0 = deskStorage.Get(desks[0].Id);
            Assert.AreEqual(desks[0].Id, cat0.Id);
            Assert.AreEqual(desks[0].Number, cat0.Number);

            // delete desk
            deskStorage.Delete(desks[3].Id);

            // get desks
            Assert.IsTrue(deskStorage.GetAll(placeId).Count() == 4);
        }

        [TestMethod]
        public void Test04DishkStorage()
        {
            var placeId = GetPlace().Id;
            var categories = GetCategories();
            IDishStorage dishStorage = (IDishStorage)_storageFactory.GetStorage<Dish>();

            /* 'Сухие Вина'
               'Горячие блюда'
               'Каши'
               'Вина' */
            // add some dishes
            var dishesInit = new Dish[,] 
            {
            {
                    new Dish() { Name= "Шато", Price=456},
                    new Dish() { Name="Бардо", Price=987},
                    new Dish() { Name="Мерло", Price=159.7m}, 
                    new Dish() { Name="Отмерло", Price=753}
                },    
            {
                    new Dish() { Name= "Борщ", Price=45m},
                    new Dish(){ Name="Щи", Price=95},
                    new Dish(){ Name="Солянка", Price=82.5m}, 
                    new Dish(){ Name="Малянка", Price=187}
                },
                {
                    new Dish() { Name= "Гречневая", Price=12},
                    new Dish(){ Name="Манная", Price=13.4m},
                    new Dish(){ Name="Пшенная", Price=14}, 
                    new Dish(){ Name="Геркулесная", Price=16}
                }                
            };
            List<Dish> dishes = new List<Dish>();
            for (int c = 0; c < 3; c++)
            {
                for (int d = 0; d < 4; d++)
                {
                    dishesInit[c, d].CategoryId = categories[c].Id;
                    var dish = dishStorage.Add(dishesInit[c, d]);
                    dishes.Add(dish);
                    Assert.IsNotNull(dish);
                    Assert.IsTrue(dish.Id > 0);
                }
            }

            // edit dish            
            dishes[3].Name = "Игристое";
            dishes[3] = dishStorage.Set(dishes[3].Id, dishes[3]);

            // get dish
            var dish0 = dishStorage.Get(dishes[0].Id);
            Assert.AreEqual(dishes[0].Id, dish0.Id);
            Assert.AreEqual(dishes[0].Name, dish0.Name);
            Assert.AreEqual(dishes[0].Price, dish0.Price);
            Assert.AreEqual(dishes[0].CategoryId, dish0.CategoryId);
            Assert.AreEqual(dishes[0].Description, dish0.Description);

            // delete dish
            dishStorage.Delete(dishes[3].Id);

            // get dishes
            Assert.IsTrue(dishStorage.GetAllOfPlace(placeId).Count() == 11);

            // get dishes
            Assert.IsTrue(dishStorage.GetAllOfCategory(categories[1].Id).Count() == 4);
        }
    }
}