using System;
using Accounting;
using Bakery.Model.Implementation;

namespace Bakery.Model.Warehouse
{
    public class Entry : Entity, IEntry
    {
        public Entry(OperationInfo opInfo)
        {
            OperationInfo = opInfo;
            Date = DateTime.Now;
        }

        public RawEntry RawEntry { get; set; }

        public decimal Count { get; set; }

        public decimal Price { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public OperationInfo OperationInfo { get; set; }

        public InvoiceType Type { get; set; }
    }
}