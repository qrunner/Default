using System.ComponentModel;
using Accounting;

namespace Bakery.Model
{
    /// <summary>
    /// Учетная запись о единице ТМЦ
    /// </summary>
    public class UnitEntry : UnitCount, IUnitEntry
    {
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DisplayName("Сумма")]
        public decimal Amount
        {
            get { return Price*Count; }
        }

        [DisplayName("Операция")]
        public virtual Operation Operation { get; set; }
    }
}