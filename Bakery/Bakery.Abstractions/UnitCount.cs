using System.ComponentModel;
using Accounting;

namespace Bakery.Model
{
    /// <summary>
    /// Количество единиц ТМЦ
    /// </summary>
    public class UnitCount : Entity, IUnitCount
    {
        [DisplayName("Количество")]
        public decimal Count { get; set; }
        
        public int UnitId
        {
            get { return Unit.Id; }
        }

        [DisplayName("Позиция")]
        public virtual Unit Unit { get; set; }
    }
}