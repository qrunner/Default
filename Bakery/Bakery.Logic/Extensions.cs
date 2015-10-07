namespace Bakery.Logic
{
    public static class Extensions
    {
        public static decimal GetSign(this InvoiceType invoiceType)
        {
            switch (invoiceType)
            {
                case InvoiceType.Shipment:
                case InvoiceType.WriteOff:
                    return -1;
                default:
                    return +1;
            }
        }
    }
}