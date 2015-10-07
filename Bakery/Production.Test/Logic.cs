using System.Collections.Generic;
using System.Linq;
using Accounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Production.Logic;

namespace Production.Test
{
    [TestClass]
    public class Logic
    {
        [TestMethod]
        public void CalculateRaw()
        {
            var raws = _order.CalculateRaw(_recipies).ToArray();

            Assert.IsNotNull(raws);
            Assert.AreEqual(4, raws.Length);
            Assert.AreEqual(4.6M, raws.Single(x => x.UnitId == 1).Count);
            Assert.AreEqual(11.5M, raws.Single(x => x.UnitId == 2).Count);
            Assert.AreEqual(8.5M, raws.Single(x => x.UnitId == 3).Count);
            Assert.AreEqual(8.4M, raws.Single(x => x.UnitId == 4).Count);
        }

        [TestMethod]
        public void CalsulateCost()
        {
            Assert.AreEqual(867M, _order.CalculateCost(_rawPrices, _recipies));
        }

        private readonly IEnumerable<UnitPrice> _rawPrices = new[]
        {
            new UnitPrice {UnitId = 1, Price = 10},
            new UnitPrice {UnitId = 2, Price = 20},
            new UnitPrice {UnitId = 3, Price = 30},
            new UnitPrice {UnitId = 4, Price = 40}
        };

        private readonly IEnumerable<IProductionInfo> _recipies = new[]
        {
            new ProductionInfo
            {
                ProductId = 1,
                Components = new[]
                {
                    new UnitCount {UnitId = 1, Count = 0.2M},
                    new UnitCount {UnitId = 2, Count = 0.5M},
                    new UnitCount {UnitId = 3, Count = 1.7M}
                }
            },
            new ProductionInfo
            {
                ProductId = 2,
                Components = new[]
                {
                    new UnitCount {UnitId = 1, Count = 1.2M},
                    new UnitCount {UnitId = 2, Count = 3M},
                    new UnitCount {UnitId = 4, Count = 2.8M}
                }
            }
        };
        
        private readonly IEnumerable<UnitCount> _order = new[]
        {
            new UnitCount {UnitId = 1, Count = 5},
            new UnitCount {UnitId = 2, Count = 3}
        };

        private class UnitPrice : IUnitInfo, IPriceInfo
        {
            public int UnitId { get; set; }
            public decimal Price { get; set; }
        }

        private class ProductionInfo : IProductionInfo
        {
            public int ProductId { get; set; }
            public IEnumerable<IUnitCount> Components { get; set; }
        }
    }
}