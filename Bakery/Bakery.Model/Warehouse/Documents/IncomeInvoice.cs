using System.Collections.Generic;
using System.Linq;
using Bakery.Model.Implementation;

namespace Bakery.Model.Warehouse.Documents
{
    /// <summary>
    /// Приходная накладная. Склад.
    /// </summary>
    public class IncomeInvoice : Document
    {

        public InvoiceType Type { get; set; }

        public IList<InvoiceItem> Items { get; set; }

        public decimal Amount
        {
            get { return Items.Sum(x => x.Amount); }
        }
    }
}