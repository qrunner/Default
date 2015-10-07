using System;
using System.Linq;
using Mcs.Model;

namespace Mcs.Server.Api
{
    public static class Mapper
    {
        public static TTo Map<TFrom, TTo>(TFrom from)
            where TFrom : class
            where TTo : class
        {
            if (typeof (TFrom) == typeof (Desk) & typeof (TTo) == typeof (Model.Json.Desk))
                return DeskToJson(from as Desk) as TTo;

            if (typeof (TFrom) == typeof (Dish) & typeof (TTo) == typeof (Model.Json.Dish))
                return DishToJson(from as Dish) as TTo;

            if (typeof (TFrom) == typeof (MenuCategory) & typeof (TTo) == typeof (Model.Json.MenuCategory))
                return MenuCategoryToJson(from as MenuCategory) as TTo;

            if (typeof (TFrom) == typeof (Place) & typeof (TTo) == typeof (Model.Json.Place))
                return PlaceToJson(from as Place) as TTo;

            if (typeof (TFrom) == typeof (Device) & typeof (TTo) == typeof (Model.Json.Device))
                return DeviceToJson(from as Device) as TTo;

            if (typeof (TFrom) == typeof (News) & typeof (TTo) == typeof (Model.Json.News))
                return NewsToJson(from as News) as TTo;

            if (typeof (TFrom) == typeof (Promo) & typeof (TTo) == typeof (Model.Json.Promo))
                return PromoToJson(from as Promo) as TTo;

            if (typeof (TFrom) == typeof (OrderDish) & typeof (TTo) == typeof (Model.Json.OrderDish))
                return OrderDishToJson(from as OrderDish) as TTo;

            if (typeof (TFrom) == typeof (Order) & typeof (TTo) == typeof (Model.Json.Order))
                return OrderToJson(from as Order) as TTo;

            if (typeof (TFrom) == typeof (Model.Json.OrderDish) & typeof (TTo) == typeof (OrderDish))
                return OrderDishFromJson(from as Model.Json.OrderDish) as TTo;

            if (typeof (TFrom) == typeof (Model.Json.Order) & typeof (TTo) == typeof (Order))
                return OrderFromJson(from as Model.Json.Order) as TTo;

            throw new NotImplementedException();
        }

        public static Func<Dish, Model.Json.Dish> DishToJson = from => new Model.Json.Dish
        {
            Id = from.Id,
            Name = from.Name,
            Description = from.Description,
            MenuCategoryId = from.MenuCategoryId,
            Price = from.Price
        };

        public static Func<Desk, Model.Json.Desk> DeskToJson = from => new Model.Json.Desk
        {
            Id = from.Id,
            Name = from.Name,
            PlaceId = from.PlaceId,
            CurrentOrderId = from.CurrentOrderId,
            Reserved = from.Reserved
        };

        public static Func<MenuCategory, Model.Json.MenuCategory> MenuCategoryToJson = from => new Model.Json.MenuCategory
        {
            Id = from.Id,
            Name = from.Name,
            PlaceId = from.PlaceId,
            ParentId = from.ParentId
        };

        public static Func<Place, Model.Json.Place> PlaceToJson = from => new Model.Json.Place
        {
            Id = from.Id,
            Name = from.Name
        };

        public static Func<Device, Model.Json.Device> DeviceToJson = from => new Model.Json.Device
        {
            Id = from.Id,
            DeviceNumber = from.DeviceId
        };

        public static Func<News, Model.Json.News> NewsToJson = from => new Model.Json.News
        {
            Id = from.Id,
            Date = from.Date,
            Description = from.Description,
            PlaceId = from.PlaceId,
            Text = from.Text,
            Title = from.Title
        };

        public static Func<Promo, Model.Json.Promo> PromoToJson = from => new Model.Json.Promo
        {
            Id = from.Id,
            PlaceId = from.PlaceId,
            Text = from.Text,
            Title = from.Title,
            EndDate = from.EndDate,
            StartDate = from.StartDate
        };

        public static Func<OrderDish, Model.Json.OrderDish> OrderDishToJson = from => new Model.Json.OrderDish
        {
            //Id = from.Id,
            DishId = from.DishId,
            //OrderId = from.OrderId,
            Quantity = from.Quantity
        };

        public static Func<Model.Json.OrderDish, OrderDish> OrderDishFromJson = from => new OrderDish
        {
            DishId = from.DishId,
            //OrderId = from.OrderId,
            Quantity = from.Quantity
        };

        public static Func<Model.Json.Order, Order> OrderFromJson = from =>
        {
            var retval = new Order
            {
                Id = from.Id,
                DeskId = from.DeskId,
                Opened = from.Opened,
                Closed = from.Closed,
                DeviceId = from.DeviceId,
                PlaceId = from.PlaceId,
                State = (OrderState) (int) from.State
            };

            if (from.Dishes != null)
                foreach (var dish in from.Dishes)
                    retval.Dishes.Add(OrderDishFromJson(dish));

            return retval;
        };

        public static Func<Order, Model.Json.Order> OrderToJson = from => new Model.Json.Order
        {
            Id = from.Id,
            Opened = from.Opened,
            State = (Model.Json.OrderState) (int) from.State,
            DeskId = from.DeskId,
            DeviceId = from.DeviceId,
            PlaceId = from.PlaceId,
            Closed = from.Closed,
            Dishes = from.Dishes.Select(OrderDishToJson).ToArray()
        };
    }
}