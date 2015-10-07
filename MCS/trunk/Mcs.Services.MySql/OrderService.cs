using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Mcs.Model;

namespace Mcs.Services.MySql
{
    public class OrderService : PlaceRelatedService<Order>, IOrderService
    {
        public IEnumerable<Order> GetByStateAndDates(int placeId, OrderState state, DateTime from, DateTime to, int skip, int take)
        {
            return Get(x => x.PlaceId == placeId &
                            x.State == state &
                            x.Opened >= from &
                            x.Closed <= to, skip, take);
        }

        public void ChangeDishQuantity(int orderId, int dishId, int delta)
        {
            using (var ctx = new Context())
            {
                var order = Table(ctx).Single(x => x.Id == orderId);
                var dish = order.Dishes.SingleOrDefault(x => x.DishId == dishId);
                if (dish != null)
                    dish.Quantity += delta;
                else
                    order.Dishes.Add(new OrderDish {DishId = dishId, OrderId = orderId, Quantity = delta});

                ctx.SaveChanges();
            }
        }

        protected override DbQuery<Order> Table(DbContext context)
        {
            return base.Table(context).Include("Dishes.Dish").Include("Desk");
        }

        bool _setOrderId = false;

        protected override void BeforeSaveInternal(Context ctx, Order item)
        {
            var desk = ctx.Desks.Single(x => x.Id == item.DeskId);
            _setOrderId = true;
            if (item.Id == 0)
            {
                item.Opened = DateTime.Now;
                if (desk.Reserved || desk.CurrentOrderId.HasValue)
                    throw new InvalidOperationException(string.Format("Стол '{0}' не доступен для заказа.", desk.Name));
            }
            else
            {
                if (item.State == OrderState.Closed)
                {
                    item.Closed = DateTime.Now;
                    desk.CurrentOrderId = null;
                    _setOrderId = false;
                }
            }
        }

        protected override void AfterSaveInternal(Context ctx, Order item)
        {
            if (_setOrderId)
            {
                var desk = ctx.Desks.Single(x => x.Id == item.DeskId);
                desk.CurrentOrderId = item.Id;
                ctx.SaveChanges();
            }
        }
    }
}