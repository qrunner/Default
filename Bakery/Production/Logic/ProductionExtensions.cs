using System.Collections.Generic;
using System.Linq;
using Accounting;

namespace Production.Logic
{
    public static class ProductionExtensions
    {
        /// <summary>
        /// Рассчитывает себестоимость для набора продуктов
        /// </summary>
        /// <typeparam name="TRaw"></typeparam>
        /// <typeparam name="TProduct"></typeparam>
        /// <param name="products"></param>
        /// <param name="rawPrices"></param>
        /// <param name="productionInfos"></param>
        /// <returns></returns>
        public static decimal CalculateCost<TProduct, TRaw>(this IEnumerable<TProduct> products, IEnumerable<TRaw> rawPrices, IEnumerable<IProductionInfo> productionInfos)
            where TProduct : IUnitInfo, ICountInfo
            where TRaw : IUnitInfo, IPriceInfo
        {
            return products.CalculateRaw(productionInfos).Select(x => x.Count*rawPrices.Single(r => r.UnitId == x.UnitId).Price).Sum();
        }

        /*public static decimal CalculateCost(this IProductionInfo productionInfo, decimal quantity)
        {
            return productionInfo.CalculateRaw(quantity).Sum();
        }*/

        /// <summary>
        /// Рассчитывает количество сырья для изготовления заказа
        /// </summary>
        /// <typeparam name="TProduct"></typeparam>
        /// <param name="products">Состав заказа</param>
        /// <param name="operationInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IUnitCount> CalculateRaw<TProduct>(this IEnumerable<TProduct> products, IEnumerable<IProductionInfo> operationInfos)
            where TProduct : IUnitInfo, ICountInfo
        {
            // вычисляем общее количество сырья для заказа
            return products.SelectMany(orderItem => operationInfos.Single(x => x.ProductId == orderItem.UnitId).CalculateRaw(orderItem.Count))
                .GroupBy(x => x.UnitId)
                .Select(group => new UnitCount {UnitId = group.Key, Count = group.Sum(x => x.Count)});
        }

        /// <summary>
        /// Рассчитывает количество сырья для изготовления заданного количества продукции
        /// </summary>
        /// <param name="productionInfo"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public static IEnumerable<IUnitCount> CalculateRaw(this IProductionInfo productionInfo, decimal quantity)
        {
            return productionInfo.Components.Select(x => new UnitCount {UnitId = x.UnitId, Count = x.Count*quantity});
        }
    }
}