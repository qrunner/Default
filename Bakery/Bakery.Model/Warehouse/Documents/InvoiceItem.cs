using Bakery.Model.Implementation;

namespace Bakery.Model.Warehouse.Documents
{
    public class InvoiceItem : Entity
    {
        public int RawId { get; set; }

        public decimal Count { get; set; }

        public decimal Price { get; set; }

        public decimal Amount
        {
            get { return Price*Count; }
        }
    }
}