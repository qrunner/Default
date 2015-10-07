using System;
using Mcs.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Mcs.Client.Storage
{
    /// <summary>
    /// Контекст базы данных EF
    /// </summary>
    internal class StorageContext : DbContext
    {
        /// <summary>
        /// ctor
        /// </summary>
        public StorageContext()
            : base("MySQLTest")
        {

        }

        /// <summary>
        /// Категориии
        /// </summary>
        public DbSet<MenuCategory> MenuCategories { get; set; }

        /// <summary>
        /// Элементы корзины
        /// </summary>
        public DbSet<Cart> Carts { get; set; }

        /// <summary>
        /// Блюда
        /// </summary>
        public DbSet<Dish> Dishes { get; set; }

        /// <summary>
        /// Заказы
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Состав заказов
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }

    /// <summary>
    /// Сторож
    /// </summary>
    public class Storage
    {
        /// <summary>
        /// Контекст EF сторожа
        /// </summary>
        private readonly StorageContext _context;

        /// <summary>
        /// ctor
        /// </summary>
        public Storage()
        {
            _context = new StorageContext();
        }

        /// <summary>
        /// Получает категориим меню
        /// </summary>
        /// <returns>Коллекция категорий</returns>
        public IEnumerable<MenuCategory> GetMenuCategories()
        {
            return _context.MenuCategories.ToList();
        }

        /// <summary>
        /// Получает блюда по идентификатору категории
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <returns>Коллекция блюд</returns>
        public IEnumerable<Dish> GetCategoryContent(int id)
        {
            return _context.Dishes.Where(l => l.Mcat_Id == id );
        }

        /// <summary>
        /// Поиск блюд по имени
        /// </summary>
        /// <param name="searchStr">Подстрока имени</param>
        /// <returns>Коллекция блюд</returns>
        public IEnumerable<Dish> SearchDishes(string searchStr)
        {
            return _context.Dishes.Where(l => l.Name.ToLower().Contains(searchStr.ToLower()));
        }

        /// <summary>
        /// Возвращает блюдо по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор блюда</param>
        /// <returns>Блюдо</returns>
        public Dish GetDish(int id)
        {
            return _context.Dishes.Single(d => d.DishId == id);
        }

        /// <summary>
        /// Добавляет блюдо в корзину если его нет в корзине. Увеличивает счетчик, если блюдо в корзине уже есть.        
        /// </summary>
        /// <param name="dishId">Идентификатор блюда</param>
        /// <param name="deviceId">Идентификатор устройства</param>
        /// <returns>Значение счетчика порций</returns>
        public int AddToCart(int dishId, string deviceId)
        {
            var cartItem = _context.Carts.SingleOrDefault(c => c.DishId == dishId && c.Device_Id == deviceId);
            if (cartItem == null)
            {
                cartItem = new Cart()
                {
                    Device_Id = deviceId,
                    DishId = dishId,
                    Quantity = 1,
                    Creation_Date = DateTime.Now
                };
                _context.Carts.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
            }
            _context.SaveChanges();

            return cartItem.Quantity;
        }

        /// <summary>
        /// Удаляет блюдо из корзины, если счетчик равен единице. Уменьшает счетчик на единицу, если счетик больше единицы
        /// </summary>
        /// <param name="dishId">Идентификатор блюда</param>
        /// <param name="deviceId">Идентификатор устройства</param>
        /// <returns>Значение счетчика порций</returns>
        public int RemoveFromCart(int dishId, string deviceId)
        {
            var cartItem = _context.Carts.SingleOrDefault(c => c.DishId == dishId && c.Device_Id == deviceId);
            var itemCount = 0;
            if (cartItem == null) return itemCount;
            if (cartItem.Quantity > 1)
            {
                cartItem.Quantity--;
                itemCount = cartItem.Quantity;
            }
            else
            {
                _context.Carts.Remove(cartItem);
            }
            _context.SaveChanges();
            return itemCount;
        }

        /// <summary>
        /// Выполняет очистку корзины
        /// </summary>
        /// <param name="deviceId">Идентфикатор устройства</param>
        public void ClearCart(string deviceId)
        {
            var cartItems = _context.Carts.Where(c => c.Device_Id == deviceId);
            foreach (var cartItem in cartItems)
            {
                _context.Carts.Remove(cartItem);
            }
            _context.SaveChanges();
        }

        /// <summary>
        /// Получает состав корзины
        /// </summary>
        /// <param name="deviceId">Идентификатор устройства</param>
        /// <returns>Коллекция элементов корзины</returns>
        public IEnumerable<Cart> GetCarts(string deviceId)
        {
            return _context.Carts.Where(c => c.Device_Id == deviceId);
        }

        public int SaveOrder(Order order, List<OrderDetail> details)
        {
            _context.Orders.Add(order);
            foreach (var item in details)
            {
                _context.OrderDetails.Add(item);
            }
            _context.SaveChanges();
            return 1;
        }
    }
}
