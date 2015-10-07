using System.Collections.Generic;
using Accounting;

namespace Production
{
    /// <summary>
    /// Компоненты / сырье, необходимые для выполнения операции по изготовлению продукции
    /// </summary>
    public interface IProductionInfo : IProductInfo
    {
        /// <summary>
        /// Компоненты, необходимые для изготовления продукта
        /// </summary>
        IEnumerable<IUnitCount> Components { get; }
    }
}