﻿using System;
using Mcs.Model;
using Mcs.Services;
using Mcs.Services.FileSystem;
using Mcs.Services.MySql;

namespace Mcs.WebExtensions
{
    class ServiceFactory : IServiceFactory
    {
        private static IPlaceService _placeService;

        public T GetService<T>() where T : class
        {
            if (typeof(T) == typeof(IPlaceService))
            {
                if (_placeService == null)
                    _placeService = new PlaceService();
                return _placeService as T;
            }

            if (typeof(T) == typeof(IDeviceService))
                return new DeviceService() as T;

            if (typeof(T) == typeof(IPlaceRelatedService<MenuCategory>))
                return new PlaceRelatedService<MenuCategory>() as T;

            if (typeof(T) == typeof(IDishService))
                return new DishService() as T;

            if (typeof(T) == typeof(IPlaceRelatedService<Desk>))
                return new PlaceRelatedService<Desk>() as T;

            if (typeof(T) == typeof(IPlaceRelatedService<News>))
                return new PlaceRelatedService<News>() as T;

            if (typeof(T) == typeof(IPlaceRelatedService<Promo>))
                return new PlaceRelatedService<Promo>() as T;

            if (typeof(T) == typeof(IOrderService))
                return new OrderService() as T;

            if (typeof(T) == typeof(IPlaceRelatedService<Order>))
                return new OrderService() as T;

            if (typeof(T) == typeof(IPictureService))
                return new PictureService() as T;

            throw new NotImplementedException();
        }
    }
}