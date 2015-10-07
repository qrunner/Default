using System;
using System.Collections.Generic;
using System.Linq;
using Production.Logic;

namespace Bakery.Model
{
    /// <summary>
    /// Заказ-наряд на производство
    /// </summary>
    internal class ProductionOrder : OrderBase
    {
        /// <summary>
        /// Дата производства
        /// </summary>
        public DateTime ProductionDate { get; set; }

        /// <summary>
        /// Клиентские заказы
        /// </summary>
        public virtual ICollection<Order> Orders { get; protected set; }

        /// <summary>
        /// Список продукции
        /// </summary>
        public virtual ICollection<UnitCount> Items { get; protected set; }

        /// <summary>
        /// Список сырья
        /// </summary>
        public virtual ICollection<UnitCount> RawMaterials { get; protected set; }

        /// <summary>
        /// Источник сырья
        /// </summary>
        public virtual AccountingSite RawSite { get; set; }

        /// <summary>
        /// Общая сумма заказа
        /// </summary>
        /// <returns></returns>
        public decimal Amount()
        {
            return Orders.Sum(o => o.Amount);
        }

        /// <summary>
        /// Пересчитывает заказ
        /// </summary>
        public void Recalculate()
        {
            Items.Clear();

            foreach (var orderItem in Orders.SelectMany(order => order.Items)
                .GroupBy(o => o.Unit)
                .Select(g => new UnitCount {Unit = g.Key, Count = g.Sum(u => u.Count)}))
            {
                Items.Add(orderItem);
            }

            using (var ctx = new Context())
            {
                RawMaterials.Clear();

                foreach (var item in Items.CalculateRaw(ctx.Recipies).Select(u => new UnitCount {Unit = ctx.Units.Single(x=>x.Id == u.UnitId), Count = u.Count}))
                    RawMaterials.Add(item);
            }
        }

        public override void TakeToProcess()
        {
            foreach (var order in Orders)
                order.TakeToProcess();

            base.TakeToProcess();
        }

        public override void MarkExecuted()
        {
            foreach (var order in Orders)
                order.MarkExecuted();

            base.MarkExecuted();
        }
    }
}