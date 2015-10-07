using System;
using Accounting;

namespace Bakery.Model.Implementation
{
    /// <summary>
    /// Учетная запись о единице ТМЦ
    /// </summary>
    public class UnitEntry : Entity, IUnitEntry
    {
        public decimal Price { get; set; }

        public decimal Count { get; set; }

        public decimal Amount
        {
            get { return Price*Count; }
        }

        public int DocumentId { get; set; }

        public DateTime Date { get; set; }

        public int UnitId { get; set; }
        
    }
}